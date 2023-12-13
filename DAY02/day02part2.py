total_power = 0

with open("day_02.in", "r") as file:
    games = file.read().strip().split("\n")

    for game in games:
        parts = game.split("; ")

        min_red = float('inf')
        min_green = float('inf')
        min_blue = float('inf')

        for part in parts:
            cubes = part.split(", ")
            for cube in cubes:
                num, color = cube.split(" ")
                num = int(num)

                if color == "red":
                    min_red = min(min_red, num)
                elif color == "green":
                    min_green = min(min_green, num)
                elif color == "blue":
                    min_blue = min(min_blue, num)

        power = min_red * min_green * min_blue
        total_power += power

print(total_power)