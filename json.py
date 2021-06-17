import json

with open("QAOC2mMYitk.txt", "r") as file:
    parsed = json.loads(file.readline())

print(json.dumps(parsed, indent=4, sort_keys=True))