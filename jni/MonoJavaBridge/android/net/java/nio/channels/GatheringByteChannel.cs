namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface GatheringByteChannel : WritableByteChannel
	{ 
		long write(java.nio.ByteBuffer[] arg0, int arg1, int arg2); 
		long write(java.nio.ByteBuffer[] arg0); 
	} 
} 
