with open("day_02.in") as fin:
    data = fin.read().strip().split("\n")

ans = 0

for line in data:
    parts = line.split(": ")[1].split("; ")
    
    valid_game = True
    for part in parts:
        cubes = part.split(", ")
        for cube in cubes:
            num, color = cube.split(" ")
            num = int(num)
            
            if (color == "red" and num > 12) or (color == "blue" and num > 14) or (color == "green" and num > 13):
                valid_game = False
                break
        
        if not valid_game:
            break
    
    if valid_game:
        game_id = int(line.split(":")[0].split(" ")[1])
        ans += game_id

print(ans)