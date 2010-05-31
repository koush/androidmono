namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class DatagramPacket : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static DatagramPacket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.DatagramPacket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.DatagramPacket(@__env); 
			} 
		} 
		internal DatagramPacket(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLength11662; 
		public int getLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.net.DatagramPacket._getLength11662); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getLength11662); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAddress11663; 
		public global::java.net.InetAddress getAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.DatagramPacket._getAddress11663)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getAddress11663)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLength11664; 
		public void setLength(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.DatagramPacket._setLength11664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setLength11664, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOffset11665; 
		public int getOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.net.DatagramPacket._getOffset11665); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getOffset11665); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPort11666; 
		public int getPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::java.net.DatagramPacket._getPort11666); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getPort11666); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getData11667; 
		public byte[] getData() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.net.DatagramPacket._getData11667)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getData11667)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setData11668; 
		public void setData(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.DatagramPacket._setData11668, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setData11668, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setData11669; 
		public void setData(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.DatagramPacket._setData11669, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setData11669, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAddress11670; 
		public void setAddress(java.net.InetAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.DatagramPacket._setAddress11670, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setAddress11670, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPort11671; 
		public void setPort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.DatagramPacket._setPort11671, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setPort11671, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSocketAddress11672; 
		public void setSocketAddress(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::java.net.DatagramPacket._setSocketAddress11672, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._setSocketAddress11672, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSocketAddress11673; 
		public global::java.net.SocketAddress getSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.DatagramPacket._getSocketAddress11673)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._getSocketAddress11673)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket11674; 
		public DatagramPacket(byte[] arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket11674, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket11675; 
		public DatagramPacket(byte[] arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket11675, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket11676; 
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.InetAddress arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket11676, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket11677; 
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.SocketAddress arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket11677, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket11678; 
		public DatagramPacket(byte[] arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket11678, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket11679; 
		public DatagramPacket(byte[] arg0, int arg1, java.net.SocketAddress arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, global::java.net.DatagramPacket._DatagramPacket11679, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.DatagramPacket.staticClass = @__class; 
			global::java.net.DatagramPacket._getLength11662 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getLength", "()I"); 
			global::java.net.DatagramPacket._getAddress11663 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.DatagramPacket._setLength11664 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setLength", "(I)V"); 
			global::java.net.DatagramPacket._getOffset11665 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getOffset", "()I"); 
			global::java.net.DatagramPacket._getPort11666 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getPort", "()I"); 
			global::java.net.DatagramPacket._getData11667 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getData", "()[B"); 
			global::java.net.DatagramPacket._setData11668 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setData", "([B)V"); 
			global::java.net.DatagramPacket._setData11669 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setData", "([BII)V"); 
			global::java.net.DatagramPacket._setAddress11670 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setAddress", "(Ljava/net/InetAddress;)V"); 
			global::java.net.DatagramPacket._setPort11671 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setPort", "(I)V"); 
			global::java.net.DatagramPacket._setSocketAddress11672 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setSocketAddress", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.DatagramPacket._getSocketAddress11673 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.DatagramPacket._DatagramPacket11674 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BII)V"); 
			global::java.net.DatagramPacket._DatagramPacket11675 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BI)V"); 
			global::java.net.DatagramPacket._DatagramPacket11676 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/InetAddress;I)V"); 
			global::java.net.DatagramPacket._DatagramPacket11677 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/SocketAddress;)V"); 
			global::java.net.DatagramPacket._DatagramPacket11678 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/InetAddress;I)V"); 
			global::java.net.DatagramPacket._DatagramPacket11679 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/SocketAddress;)V"); 
		} 
	} 
} 
