import pygame
import random
import math


def cars():
    pygame.init()
    lambo = pygame.image.load('Lambo.ico')
    lambo = pygame.transform.scale(lambo, (177, 84))
    road = [pygame.image.load('road1.png'), pygame.image.load('road2.png'), pygame.image.load('road3.png')]
    e_cars = [pygame.image.load('EnemyCar.png'), pygame.image.load('EnemyCar.png'),
              pygame.image.load('EnemyCar2.png'), pygame.image.load('EnemyCar2.png')]
    pygame.mixer.music.load('Driving.wav')
    pygame.mixer.music.play(-1)

    for r in range(3):
        road[r] = pygame.transform.scale(road[r], (1200, 700))

    for e in range(4):
        e_cars[e] = pygame.transform.scale(e_cars[e], (150, 81))

    pygame.display.set_caption('Carogger')

    screen_width = 1200
    screen_height = 800

    screen = pygame.display.set_mode((screen_width, screen_height))

    y = 50
    x = [-100, -100, -100, -100]
    speed = 35
    road_num = 0

    run = True
    while run:
        pygame.time.delay(100)

        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                run = False

        keys = pygame.key.get_pressed()

        if keys[pygame.K_UP] and y >= 0:
            y -= speed

        if keys[pygame.K_DOWN] and y <= 700:
            y += speed

        screen.fill((0, 150, 0))
        screen.blit(road[road_num], (0, 50))

        if road_num == 2:
            road_num = 0

        road_num += 1
        move_enemy_cars(e_cars, screen, x, y)
        screen.blit(lambo, (50, y))
        pygame.display.update()


def detect_collision(lambo_y, ecar_x, ecar_y, screen):
    dist = math.sqrt((ecar_x - 50)**2 + (ecar_y - lambo_y)**2)
    if dist <= 100:
        game_over(screen)


def text_format(message, text_font, text_size, text_color):
    font = pygame.font.Font(text_font, text_size)
    text = font.render(message, 0, text_color)

    return text


def game_over(screen):
    pygame.mixer.music.stop()
    pygame.mixer.Sound.play(pygame.mixer.Sound('Crash.wav'))
    gameover_text = text_format('Game Over!', 'LuckiestGuy-Regular.ttf', 120, (0, 0, 0))
    return_text = text_format('Press enter to restart or press \'Q\' to quit', 'LuckiestGuy-Regular.ttf', 40, (0, 0, 0))
    screen.blit(gameover_text, (250, 200))
    screen.blit(return_text, (200, 300))

    pygame.display.update()

    while True:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                quit()
            if event.type == pygame.KEYDOWN:
                if event.key == pygame.K_RETURN:
                    cars()
                if event.key == pygame.K_q:
                    pygame.quit()
                    quit()


def move_enemy_cars(e_cars, screen, x, lambo_y):
    y = 87.5

    for i in range(4):
        if x[i] <= -100:
            x[i] = random.randint(1200, 1900)

        screen.blit(e_cars[i], (x[i], y))
        detect_collision(lambo_y, x[i], y, screen)
        y += 175
        x[i] -= 30
