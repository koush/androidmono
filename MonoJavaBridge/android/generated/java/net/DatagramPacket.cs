namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DatagramPacket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal DatagramPacket(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new int Length
		{
			get
			{
				return getLength();
			}
			set
			{
				setLength(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLength21373;
		public int getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramPacket.staticClass, "getLength", "()I", ref global::java.net.DatagramPacket._getLength21373);
		}
		public new global::java.net.InetAddress Address
		{
			get
			{
				return getAddress();
			}
			set
			{
				setAddress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAddress21374;
		public global::java.net.InetAddress getAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramPacket.staticClass, "getAddress", "()Ljava/net/InetAddress;", ref global::java.net.DatagramPacket._getAddress21374) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setLength21375;
		public void setLength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setLength", "(I)V", ref global::java.net.DatagramPacket._setLength21375, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Offset
		{
			get
			{
				return getOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOffset21376;
		public int getOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramPacket.staticClass, "getOffset", "()I", ref global::java.net.DatagramPacket._getOffset21376);
		}
		public new int Port
		{
			get
			{
				return getPort();
			}
			set
			{
				setPort(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPort21377;
		public int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramPacket.staticClass, "getPort", "()I", ref global::java.net.DatagramPacket._getPort21377);
		}
		public new byte[] Data
		{
			get
			{
				return getData();
			}
			set
			{
				setData(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getData21378;
		public byte[] getData()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.net.DatagramPacket.staticClass, "getData", "()[B", ref global::java.net.DatagramPacket._getData21378) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _setData21379;
		public void setData(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setData", "([B)V", ref global::java.net.DatagramPacket._setData21379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setData21380;
		public void setData(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setData", "([BII)V", ref global::java.net.DatagramPacket._setData21380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAddress21381;
		public void setAddress(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setAddress", "(Ljava/net/InetAddress;)V", ref global::java.net.DatagramPacket._setAddress21381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPort21382;
		public void setPort(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setPort", "(I)V", ref global::java.net.DatagramPacket._setPort21382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSocketAddress21383;
		public void setSocketAddress(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setSocketAddress", "(Ljava/net/SocketAddress;)V", ref global::java.net.DatagramPacket._setSocketAddress21383, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.net.SocketAddress SocketAddress
		{
			get
			{
				return getSocketAddress();
			}
			set
			{
				setSocketAddress(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSocketAddress21384;
		public global::java.net.SocketAddress getSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramPacket.staticClass, "getSocketAddress", "()Ljava/net/SocketAddress;", ref global::java.net.DatagramPacket._getSocketAddress21384) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21385;
		public DatagramPacket(byte[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._DatagramPacket21385.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._DatagramPacket21385 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21386;
		public DatagramPacket(byte[] arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._DatagramPacket21386.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._DatagramPacket21386 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21387;
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.InetAddress arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._DatagramPacket21387.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._DatagramPacket21387 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21388;
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.SocketAddress arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._DatagramPacket21388.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._DatagramPacket21388 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/SocketAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21389;
		public DatagramPacket(byte[] arg0, int arg1, java.net.InetAddress arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._DatagramPacket21389.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._DatagramPacket21389 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21390;
		public DatagramPacket(byte[] arg0, int arg1, java.net.SocketAddress arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._DatagramPacket21390.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._DatagramPacket21390 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/SocketAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21390, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static DatagramPacket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramPacket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramPacket"));
		}
		internal static void InitJNI()
		{
		}
	}
}
