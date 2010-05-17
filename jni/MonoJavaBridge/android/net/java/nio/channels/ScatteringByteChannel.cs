namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ScatteringByteChannel : ReadableByteChannel
	{ 
		long read(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		long read(java.nio.ByteBuffer[] arg0); 
	} 
} 
