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
		private static global::MonoJavaBridge.MethodId _m0;
		public int getLength()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramPacket.staticClass, "getLength", "()I", ref global::java.net.DatagramPacket._m0);
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
		private static global::MonoJavaBridge.MethodId _m1;
		public global::java.net.InetAddress getAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramPacket.staticClass, "getAddress", "()Ljava/net/InetAddress;", ref global::java.net.DatagramPacket._m1) as java.net.InetAddress;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public void setLength(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setLength", "(I)V", ref global::java.net.DatagramPacket._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Offset
		{
			get
			{
				return getOffset();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public int getOffset()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramPacket.staticClass, "getOffset", "()I", ref global::java.net.DatagramPacket._m3);
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
		private static global::MonoJavaBridge.MethodId _m4;
		public int getPort()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.net.DatagramPacket.staticClass, "getPort", "()I", ref global::java.net.DatagramPacket._m4);
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
		private static global::MonoJavaBridge.MethodId _m5;
		public byte[] getData()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::java.net.DatagramPacket.staticClass, "getData", "()[B", ref global::java.net.DatagramPacket._m5) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void setData(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setData", "([B)V", ref global::java.net.DatagramPacket._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void setData(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setData", "([BII)V", ref global::java.net.DatagramPacket._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public void setAddress(java.net.InetAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setAddress", "(Ljava/net/InetAddress;)V", ref global::java.net.DatagramPacket._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public void setPort(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setPort", "(I)V", ref global::java.net.DatagramPacket._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public void setSocketAddress(java.net.SocketAddress arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.net.DatagramPacket.staticClass, "setSocketAddress", "(Ljava/net/SocketAddress;)V", ref global::java.net.DatagramPacket._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static global::MonoJavaBridge.MethodId _m11;
		public global::java.net.SocketAddress getSocketAddress()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.net.DatagramPacket.staticClass, "getSocketAddress", "()Ljava/net/SocketAddress;", ref global::java.net.DatagramPacket._m11) as java.net.SocketAddress;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public DatagramPacket(byte[] arg0, int arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._m12.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._m12 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BII)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public DatagramPacket(byte[] arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._m13.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._m13 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BI)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.InetAddress arg3, int arg4) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._m14.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._m14 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.SocketAddress arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._m15.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._m15 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/SocketAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public DatagramPacket(byte[] arg0, int arg1, java.net.InetAddress arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._m16.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._m16 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/InetAddress;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public DatagramPacket(byte[] arg0, int arg1, java.net.SocketAddress arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.net.DatagramPacket._m17.native == global::System.IntPtr.Zero)
				global::java.net.DatagramPacket._m17 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/SocketAddress;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static DatagramPacket()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramPacket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramPacket"));
		}
	}
}
