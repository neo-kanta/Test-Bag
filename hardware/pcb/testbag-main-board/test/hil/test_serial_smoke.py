import argparse
import logging
import serial
import time


def main() -> int:
    parser = argparse.ArgumentParser()
    parser.add_argument("--port", required=True)
    parser.add_argument("--baud", type=int, default=115200)
    parser.add_argument("--cmd", default=":?\\n")
    args = parser.parse_args()

    logging.basicConfig(level=logging.INFO, format="%(asctime)s %(levelname)s %(message)s")

    with serial.Serial(args.port, args.baud, timeout=2) as ser:
        time.sleep(1)
        logging.info("Sending command: %s", args.cmd.strip())
        ser.write(args.cmd.encode("utf-8"))
        response = ser.readline().decode("utf-8", errors="replace").strip()
        logging.info("Response: %s", response)

        if not response:
            logging.error("No response from DUT")
            return 1

    return 0


if __name__ == "__main__":
    raise SystemExit(main())
