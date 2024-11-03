from pathlib import Path
from ScriptCollection.TasksForCommonProjectStructure import TasksForCommonProjectStructure


def run_example():
    TasksForCommonProjectStructure().run_dockerfile_example(str(Path(__file__).absolute()), 3, True)
    # HINT now obtain the serviceaddress from Volumes/Keys/hostname and open your tor-browser and open http://<serviceaddress>:80


if __name__ == "__main__":
    run_example()
