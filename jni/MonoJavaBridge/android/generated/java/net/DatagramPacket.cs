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
		internal static global::MonoJavaBridge.MethodId _getLength15710;
		public int getLength() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramPacket._getLength15710);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getLength15710);
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
		internal static global::MonoJavaBridge.MethodId _getAddress15711;
		public global::java.net.InetAddress getAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramPacket._getAddress15711)) as java.net.InetAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getAddress15711)) as java.net.InetAddress;
		}
		internal static global::MonoJavaBridge.MethodId _setLength15712;
		public void setLength(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setLength15712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setLength15712, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Offset
		{
			get
			{
				return getOffset();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOffset15713;
		public int getOffset() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramPacket._getOffset15713);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getOffset15713);
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
		internal static global::MonoJavaBridge.MethodId _getPort15714;
		public int getPort() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.net.DatagramPacket._getPort15714);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getPort15714);
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
		internal static global::MonoJavaBridge.MethodId _getData15715;
		public byte[] getData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramPacket._getData15715)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getData15715)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _setData15716;
		public void setData(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setData15716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setData15716, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setData15717;
		public void setData(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setData15717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setData15717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAddress15718;
		public void setAddress(java.net.InetAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setAddress15718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setAddress15718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPort15719;
		public void setPort(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setPort15719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setPort15719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setSocketAddress15720;
		public void setSocketAddress(java.net.SocketAddress arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.net.DatagramPacket._setSocketAddress15720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setSocketAddress15720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getSocketAddress15721;
		public global::java.net.SocketAddress getSocketAddress() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.net.DatagramPacket._getSocketAddress15721)) as java.net.SocketAddress;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getSocketAddress15721)) as java.net.SocketAddress;
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket15722;
		public DatagramPacket(byte[] arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket15722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket15723;
		public DatagramPacket(byte[] arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket15723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket15724;
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.InetAddress arg3, int arg4)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket15724, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket15725;
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.SocketAddress arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket15725, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket15726;
		public DatagramPacket(byte[] arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket15726, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _DatagramPacket15727;
		public DatagramPacket(byte[] arg0, int arg1, java.net.SocketAddress arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket15727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.net.DatagramPacket.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/net/DatagramPacket"));
			global::java.net.DatagramPacket._getLength15710 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getLength", "()I");
			global::java.net.DatagramPacket._getAddress15711 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getAddress", "()Ljava/net/InetAddress;");
			global::java.net.DatagramPacket._setLength15712 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setLength", "(I)V");
			global::java.net.DatagramPacket._getOffset15713 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getOffset", "()I");
			global::java.net.DatagramPacket._getPort15714 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getPort", "()I");
			global::java.net.DatagramPacket._getData15715 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getData", "()[B");
			global::java.net.DatagramPacket._setData15716 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setData", "([B)V");
			global::java.net.DatagramPacket._setData15717 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setData", "([BII)V");
			global::java.net.DatagramPacket._setAddress15718 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setAddress", "(Ljava/net/InetAddress;)V");
			global::java.net.DatagramPacket._setPort15719 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setPort", "(I)V");
			global::java.net.DatagramPacket._setSocketAddress15720 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "setSocketAddress", "(Ljava/net/SocketAddress;)V");
			global::java.net.DatagramPacket._getSocketAddress15721 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "getSocketAddress", "()Ljava/net/SocketAddress;");
			global::java.net.DatagramPacket._DatagramPacket15722 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BII)V");
			global::java.net.DatagramPacket._DatagramPacket15723 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BI)V");
			global::java.net.DatagramPacket._DatagramPacket15724 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/InetAddress;I)V");
			global::java.net.DatagramPacket._DatagramPacket15725 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/SocketAddress;)V");
			global::java.net.DatagramPacket._DatagramPacket15726 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/InetAddress;I)V");
			global::java.net.DatagramPacket._DatagramPacket15727 = @__env.GetMethodIDNoThrow(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/SocketAddress;)V");
		}
	}
}
