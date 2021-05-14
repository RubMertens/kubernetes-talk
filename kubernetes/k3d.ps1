k3d cluster create talk --registry-use k3d-local -p 30000:30000@server[0]
kubectl config use-context k3d-talk