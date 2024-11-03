import sys
from pathlib import Path
from ScriptCollection.TasksForCommonProjectStructure import TasksForCommonProjectStructure


def run_example():
    TasksForCommonProjectStructure().run_dockerfile_example(str(Path(__file__).absolute()), 3, True, False, sys.argv)


if __name__ == "__main__":
    run_example()
