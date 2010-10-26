namespace java.net
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class DatagramPacket : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DatagramPacket()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getLength21372;
		public int getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramPacket._getLength21372);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getLength21372);
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
		internal static global::MonoJavaBridge.MethodId _getAddress21373;
		public global::java.net.InetAddress getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramPacket._getAddress21373)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getAddress21373)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setLength21374;
		public void setLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setLength21374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setLength21374, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Offset
		{
			get
			{
				return getOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOffset21375;
		public int getOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramPacket._getOffset21375);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getOffset21375);
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
		internal static global::MonoJavaBridge.MethodId _getPort21376;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramPacket._getPort21376);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getPort21376);
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
		internal static global::MonoJavaBridge.MethodId _getData21377;
		public byte[] getData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramPacket._getData21377)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getData21377)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _setData21378;
		public void setData(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setData21378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setData21378, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setData21379;
		public void setData(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setData21379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setData21379, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAddress21380;
		public void setAddress(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setAddress21380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setAddress21380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPort21381;
		public void setPort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setPort21381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setPort21381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSocketAddress21382;
		public void setSocketAddress(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setSocketAddress21382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setSocketAddress21382, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSocketAddress21383;
		public global::java.net.SocketAddress getSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramPacket._getSocketAddress21383)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getSocketAddress21383)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21384;
		public DatagramPacket(byte[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21384, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21385;
		public DatagramPacket(byte[] arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21386;
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.InetAddress arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21387;
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.SocketAddress arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21388;
		public DatagramPacket(byte[] arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket21389;
		public DatagramPacket(byte[] arg0, int arg1, java.net.SocketAddress arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket21389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramPacket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramPacket"));
			global::java.net.DatagramPacket._getLength21372 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getLength", "()I");
			global::java.net.DatagramPacket._getAddress21373 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramPacket._setLength21374 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setLength", "(I)V");
			global::java.net.DatagramPacket._getOffset21375 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getOffset", "()I");
			global::java.net.DatagramPacket._getPort21376 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getPort", "()I");
			global::java.net.DatagramPacket._getData21377 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getData", "()[B");
			global::java.net.DatagramPacket._setData21378 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setData", "([B)V");
			global::java.net.DatagramPacket._setData21379 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setData", "([BII)V");
			global::java.net.DatagramPacket._setAddress21380 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setAddress", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramPacket._setPort21381 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setPort", "(I)V");
			global::java.net.DatagramPacket._setSocketAddress21382 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setSocketAddress", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramPacket._getSocketAddress21383 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramPacket._DatagramPacket21384 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BII)V");
			global::java.net.DatagramPacket._DatagramPacket21385 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BI)V");
			global::java.net.DatagramPacket._DatagramPacket21386 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/InetAddress;I)V");
			global::java.net.DatagramPacket._DatagramPacket21387 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/SocketAddress;)V");
			global::java.net.DatagramPacket._DatagramPacket21388 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/InetAddress;I)V");
			global::java.net.DatagramPacket._DatagramPacket21389 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/SocketAddress;)V");
		}
	}
}
