namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class DatagramPacket : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static DatagramPacket() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.DatagramPacket), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getLength10836; 
		public int getLength() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				return @__env.CallIntMethod(this, _getLength10836); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.DatagramPacket.staticClass, _getLength10836); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAddress10837; 
		public java.net.InetAddress getAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallObjectMethodPtr(this, _getAddress10837)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.DatagramPacket.staticClass, _getAddress10837)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLength10838; 
		public void setLength(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				@__env.CallVoidMethod(this, _setLength10838, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramPacket.staticClass, _setLength10838, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOffset10839; 
		public int getOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				return @__env.CallIntMethod(this, _getOffset10839); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.DatagramPacket.staticClass, _getOffset10839); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPort10840; 
		public int getPort() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				return @__env.CallIntMethod(this, _getPort10840); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.DatagramPacket.staticClass, _getPort10840); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getData10841; 
		public byte[] getData() 
		{ 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getData10841)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.DatagramPacket.staticClass, _getData10841)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setData10842; 
		public void setData(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				@__env.CallVoidMethod(this, _setData10842, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramPacket.staticClass, _setData10842, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setData10843; 
		public void setData(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				@__env.CallVoidMethod(this, _setData10843, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramPacket.staticClass, _setData10843, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAddress10844; 
		public void setAddress(java.net.InetAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				@__env.CallVoidMethod(this, _setAddress10844, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramPacket.staticClass, _setAddress10844, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPort10845; 
		public void setPort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				@__env.CallVoidMethod(this, _setPort10845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramPacket.staticClass, _setPort10845, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSocketAddress10846; 
		public void setSocketAddress(java.net.SocketAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				@__env.CallVoidMethod(this, _setSocketAddress10846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, java.net.DatagramPacket.staticClass, _setSocketAddress10846, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSocketAddress10847; 
		public java.net.SocketAddress getSocketAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.DatagramPacket)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallObjectMethodPtr(this, _getSocketAddress10847)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.SocketAddress>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.DatagramPacket.staticClass, _getSocketAddress10847)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket10848; 
		public DatagramPacket(byte[] arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, _DatagramPacket10848, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket10849; 
		public DatagramPacket(byte[] arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, _DatagramPacket10849, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket10850; 
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.InetAddress arg3, int arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, _DatagramPacket10850, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket10851; 
		public DatagramPacket(byte[] arg0, int arg1, int arg2, java.net.SocketAddress arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, _DatagramPacket10851, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket10852; 
		public DatagramPacket(byte[] arg0, int arg1, java.net.InetAddress arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, _DatagramPacket10852, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _DatagramPacket10853; 
		public DatagramPacket(byte[] arg0, int arg1, java.net.SocketAddress arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(java.net.DatagramPacket.staticClass, _DatagramPacket10853, this, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.DatagramPacket.staticClass = @__class; 
			global::java.net.DatagramPacket._getLength10836 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getLength", "()I"); 
			global::java.net.DatagramPacket._getAddress10837 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getAddress", "()Ljava/net/InetAddress;"); 
			global::java.net.DatagramPacket._setLength10838 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setLength", "(I)V"); 
			global::java.net.DatagramPacket._getOffset10839 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getOffset", "()I"); 
			global::java.net.DatagramPacket._getPort10840 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getPort", "()I"); 
			global::java.net.DatagramPacket._getData10841 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getData", "()[B"); 
			global::java.net.DatagramPacket._setData10842 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setData", "([B)V"); 
			global::java.net.DatagramPacket._setData10843 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setData", "([BII)V"); 
			global::java.net.DatagramPacket._setAddress10844 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setAddress", "(Ljava/net/InetAddress;)V"); 
			global::java.net.DatagramPacket._setPort10845 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setPort", "(I)V"); 
			global::java.net.DatagramPacket._setSocketAddress10846 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "setSocketAddress", "(Ljava/net/SocketAddress;)V"); 
			global::java.net.DatagramPacket._getSocketAddress10847 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "getSocketAddress", "()Ljava/net/SocketAddress;"); 
			global::java.net.DatagramPacket._DatagramPacket10848 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BII)V"); 
			global::java.net.DatagramPacket._DatagramPacket10849 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BI)V"); 
			global::java.net.DatagramPacket._DatagramPacket10850 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/InetAddress;I)V"); 
			global::java.net.DatagramPacket._DatagramPacket10851 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BIILjava/net/SocketAddress;)V"); 
			global::java.net.DatagramPacket._DatagramPacket10852 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/InetAddress;I)V"); 
			global::java.net.DatagramPacket._DatagramPacket10853 = @__env.GetMethodID(global::java.net.DatagramPacket.staticClass, "<init>", "([BILjava/net/SocketAddress;)V"); 
		} 
	} 
} 
