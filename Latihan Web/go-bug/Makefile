GO_PACKAGE := ""

GO_MODULE := "github.com/StevenLie14/go-bug"

.PHONY:protoc-go

protoc-go:
	protoc --go_opt=module=${GO_MODULE} --go_out=. \
    	--go-grpc_opt=module=${GO_MODULE} --go-grpc_out=. \
		proto/*.proto
