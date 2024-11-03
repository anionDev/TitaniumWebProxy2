import sys
from pathlib import Path
from ScriptCollection.TasksForCommonProjectStructure import TasksForCommonProjectStructure


def build():
    t = TasksForCommonProjectStructure()
    runtime = "win-x64"
    verbosity = 1
    commandline_args = sys.argv
    buildscript_file = str(Path(__file__).absolute())
    default_target_environment_type = TasksForCommonProjectStructure.get_qualitycheck_environment_name()
    t.standardized_tasks_build_for_dotnet_project(buildscript_file, default_target_environment_type,
                                                  t.get_default_target_environmenttype_mapping(), [runtime], verbosity,  commandline_args)
    t.generate_openapi_file(buildscript_file, runtime, verbosity, commandline_args)


if __name__ == "__main__":
    build()
