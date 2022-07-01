#! /bin/sh
ansible-playbook -i inventory api_setup.yml
ansible-playbook -i inventory db_server_setup.yml
