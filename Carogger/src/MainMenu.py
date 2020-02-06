import pygame
from src.Cars import cars


def text_format(message, text_font, text_size, text_color):
    font = pygame.font.Font(text_font, text_size)
    text = font.render(message, 0, text_color)

    return text


def main_menu():
    pygame.init()
    pygame.display.set_caption('Carogger')

    screen_width = 1200
    screen_height = 800

    screen = pygame.display.set_mode((screen_width, screen_height))

    white = (255, 255, 255)
    black = (0, 0, 0)
    font = "LuckiestGuy-Regular.ttf"
    pygame.mixer.music.load('Werq.wav')
    pygame.mixer.music.play(-1)

    menu = True
    selected = "start"

    screen.fill((0, 150, 0))
    pygame.draw.rect(screen, (70, 70, 70), (0, 70, 1200, 650))
    pygame.draw.rect(screen, (255, 255, 0), (0, 400, 1200, 10))
    pygame.draw.rect(screen, (255, 255, 0), (0, 380, 1200, 10))

    while menu:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                pygame.quit()
                quit()
            if event.type == pygame.KEYDOWN:
                if event.key == pygame.K_UP:
                    selected = "start"
                elif event.key == pygame.K_DOWN:
                    selected = "quit"
                if event.key == pygame.K_RETURN:
                    if selected == "start":
                        cars()
                        pygame.quit()
                        quit()
                    if selected == "quit":
                        pygame.quit()
                        quit()

        # Main Menu UI
        title = text_format("Carogger", font, 90, white)
        if selected == "start":
            text_start = text_format("Start", font, 75, white)
        else:
            text_start = text_format("Start", font, 75, black)
        if selected == "quit":
            text_quit = text_format("Quit", font, 75, white)
        else:
            text_quit = text_format("Quit", font, 75, black)

        title_rect = title.get_rect()
        start_rect = text_start.get_rect()
        quit_rect = text_quit.get_rect()

        # Main Menu Text
        screen.blit(title, (screen_width / 2 - (title_rect[2] / 2), 80))
        screen.blit(text_start, (screen_width / 2 - (start_rect[2] / 2), 300))
        screen.blit(text_quit, (screen_width / 2 - (quit_rect[2] / 2), 400))

        pygame.display.update()


main_menu()
pygame.quit()
quit()
