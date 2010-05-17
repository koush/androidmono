namespace java.nio.channels 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Channel : java.io.Closeable
	{ 
		new void close(); 
		bool isOpen(); 
	} 
} 
