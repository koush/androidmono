namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class NetworkInterface : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static NetworkInterface() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.NetworkInterface), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.NetworkInterface(@__env); 
			} 
		} 
		internal NetworkInterface(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11763; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallIntMethod(this, _hashCode11763); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.NetworkInterface.staticClass, _hashCode11763); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11764; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _equals11764, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _equals11764, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11765; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString11765)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _toString11765)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName11766; 
		public java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName11766)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getName11766)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParent11767; 
		public java.net.NetworkInterface getParent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.NetworkInterface>(@__env, @__env.CallObjectMethodPtr(this, _getParent11767)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.NetworkInterface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getParent11767)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName11768; 
		public java.lang.String getDisplayName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayName11768)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getDisplayName11768)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByName11769; 
		public static java.net.NetworkInterface getByName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.NetworkInterface>(@__env, @__env.CallStaticObjectMethodPtr(java.net.NetworkInterface.staticClass, _getByName11769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInetAddresses11770; 
		public java.util.Enumeration getInetAddresses() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallObjectMethodPtr(this, _getInetAddresses11770)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getInetAddresses11770)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterfaceAddresses11771; 
		public java.util.List getInterfaceAddresses() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getInterfaceAddresses11771)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getInterfaceAddresses11771)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubInterfaces11772; 
		public java.util.Enumeration getSubInterfaces() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallObjectMethodPtr(this, _getSubInterfaces11772)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getSubInterfaces11772)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByInetAddress11773; 
		public static java.net.NetworkInterface getByInetAddress(java.net.InetAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.NetworkInterface>(@__env, @__env.CallStaticObjectMethodPtr(java.net.NetworkInterface.staticClass, _getByInetAddress11773, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkInterfaces11774; 
		public static java.util.Enumeration getNetworkInterfaces() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallStaticObjectMethodPtr(java.net.NetworkInterface.staticClass, _getNetworkInterfaces11774)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isUp11775; 
		public bool isUp() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _isUp11775); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _isUp11775); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLoopback11776; 
		public bool isLoopback() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _isLoopback11776); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _isLoopback11776); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPointToPoint11777; 
		public bool isPointToPoint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _isPointToPoint11777); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _isPointToPoint11777); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _supportsMulticast11778; 
		public bool supportsMulticast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _supportsMulticast11778); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _supportsMulticast11778); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHardwareAddress11779; 
		public byte[] getHardwareAddress() 
		{ 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getHardwareAddress11779)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getHardwareAddress11779)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMTU11780; 
		public int getMTU() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallIntMethod(this, _getMTU11780); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.NetworkInterface.staticClass, _getMTU11780); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isVirtual11781; 
		public bool isVirtual() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _isVirtual11781); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _isVirtual11781); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.NetworkInterface.staticClass = @__class; 
			global::java.net.NetworkInterface._hashCode11763 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "hashCode", "()I"); 
			global::java.net.NetworkInterface._equals11764 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.net.NetworkInterface._toString11765 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.NetworkInterface._getName11766 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getName", "()Ljava/lang/String;"); 
			global::java.net.NetworkInterface._getParent11767 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getParent", "()Ljava/net/NetworkInterface;"); 
			global::java.net.NetworkInterface._getDisplayName11768 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getDisplayName", "()Ljava/lang/String;"); 
			global::java.net.NetworkInterface._getByName11769 = @__env.GetStaticMethodID(global::java.net.NetworkInterface.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;"); 
			global::java.net.NetworkInterface._getInetAddresses11770 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getInetAddresses", "()Ljava/util/Enumeration;"); 
			global::java.net.NetworkInterface._getInterfaceAddresses11771 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getInterfaceAddresses", "()Ljava/util/List;"); 
			global::java.net.NetworkInterface._getSubInterfaces11772 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getSubInterfaces", "()Ljava/util/Enumeration;"); 
			global::java.net.NetworkInterface._getByInetAddress11773 = @__env.GetStaticMethodID(global::java.net.NetworkInterface.staticClass, "getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;"); 
			global::java.net.NetworkInterface._getNetworkInterfaces11774 = @__env.GetStaticMethodID(global::java.net.NetworkInterface.staticClass, "getNetworkInterfaces", "()Ljava/util/Enumeration;"); 
			global::java.net.NetworkInterface._isUp11775 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "isUp", "()Z"); 
			global::java.net.NetworkInterface._isLoopback11776 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "isLoopback", "()Z"); 
			global::java.net.NetworkInterface._isPointToPoint11777 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "isPointToPoint", "()Z"); 
			global::java.net.NetworkInterface._supportsMulticast11778 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "supportsMulticast", "()Z"); 
			global::java.net.NetworkInterface._getHardwareAddress11779 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getHardwareAddress", "()[B"); 
			global::java.net.NetworkInterface._getMTU11780 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getMTU", "()I"); 
			global::java.net.NetworkInterface._isVirtual11781 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "isVirtual", "()Z"); 
		} 
	} 
} 
