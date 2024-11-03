import sys
from pathlib import Path
from ScriptCollection.TasksForCommonProjectStructure import TasksForCommonProjectStructure


def run_example():
    TasksForCommonProjectStructure().run_dockerfile_example(str(Path(__file__).absolute()), 3, True, True, sys.argv)
   # HINT now open your browser and open http://127.0.0.1:80

if __name__ == "__main__":
    run_example()
