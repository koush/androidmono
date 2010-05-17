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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode10935; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallIntMethod(this, _hashCode10935); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.NetworkInterface.staticClass, _hashCode10935); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals10936; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _equals10936, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _equals10936, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString10937; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10937)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _toString10937)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getName10938; 
		public java.lang.String getName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getName10938)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getName10938)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParent10939; 
		public java.net.NetworkInterface getParent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.NetworkInterface>(@__env, @__env.CallObjectMethodPtr(this, _getParent10939)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.NetworkInterface>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getParent10939)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDisplayName10940; 
		public java.lang.String getDisplayName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getDisplayName10940)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getDisplayName10940)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByName10941; 
		public static java.net.NetworkInterface getByName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.NetworkInterface>(@__env, @__env.CallStaticObjectMethodPtr(java.net.NetworkInterface.staticClass, _getByName10941, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInetAddresses10942; 
		public java.util.Enumeration getInetAddresses() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallObjectMethodPtr(this, _getInetAddresses10942)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getInetAddresses10942)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterfaceAddresses10943; 
		public java.util.List getInterfaceAddresses() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallObjectMethodPtr(this, _getInterfaceAddresses10943)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.List>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getInterfaceAddresses10943)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubInterfaces10944; 
		public java.util.Enumeration getSubInterfaces() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallObjectMethodPtr(this, _getSubInterfaces10944)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getSubInterfaces10944)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByInetAddress10945; 
		public static java.net.NetworkInterface getByInetAddress(java.net.InetAddress arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.NetworkInterface>(@__env, @__env.CallStaticObjectMethodPtr(java.net.NetworkInterface.staticClass, _getByInetAddress10945, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkInterfaces10946; 
		public static java.util.Enumeration getNetworkInterfaces() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallStaticObjectMethodPtr(java.net.NetworkInterface.staticClass, _getNetworkInterfaces10946)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isUp10947; 
		public bool isUp() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _isUp10947); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _isUp10947); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLoopback10948; 
		public bool isLoopback() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _isLoopback10948); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _isLoopback10948); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPointToPoint10949; 
		public bool isPointToPoint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _isPointToPoint10949); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _isPointToPoint10949); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _supportsMulticast10950; 
		public bool supportsMulticast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _supportsMulticast10950); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _supportsMulticast10950); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHardwareAddress10951; 
		public byte[] getHardwareAddress() 
		{ 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getHardwareAddress10951)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.NetworkInterface.staticClass, _getHardwareAddress10951)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMTU10952; 
		public int getMTU() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallIntMethod(this, _getMTU10952); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.NetworkInterface.staticClass, _getMTU10952); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isVirtual10953; 
		public bool isVirtual() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.NetworkInterface)) 
				return @__env.CallBooleanMethod(this, _isVirtual10953); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.NetworkInterface.staticClass, _isVirtual10953); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.NetworkInterface.staticClass = @__class; 
			global::java.net.NetworkInterface._hashCode10935 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "hashCode", "()I"); 
			global::java.net.NetworkInterface._equals10936 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.net.NetworkInterface._toString10937 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.NetworkInterface._getName10938 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getName", "()Ljava/lang/String;"); 
			global::java.net.NetworkInterface._getParent10939 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getParent", "()Ljava/net/NetworkInterface;"); 
			global::java.net.NetworkInterface._getDisplayName10940 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getDisplayName", "()Ljava/lang/String;"); 
			global::java.net.NetworkInterface._getByName10941 = @__env.GetStaticMethodID(global::java.net.NetworkInterface.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/NetworkInterface;"); 
			global::java.net.NetworkInterface._getInetAddresses10942 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getInetAddresses", "()Ljava/util/Enumeration;"); 
			global::java.net.NetworkInterface._getInterfaceAddresses10943 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getInterfaceAddresses", "()Ljava/util/List;"); 
			global::java.net.NetworkInterface._getSubInterfaces10944 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getSubInterfaces", "()Ljava/util/Enumeration;"); 
			global::java.net.NetworkInterface._getByInetAddress10945 = @__env.GetStaticMethodID(global::java.net.NetworkInterface.staticClass, "getByInetAddress", "(Ljava/net/InetAddress;)Ljava/net/NetworkInterface;"); 
			global::java.net.NetworkInterface._getNetworkInterfaces10946 = @__env.GetStaticMethodID(global::java.net.NetworkInterface.staticClass, "getNetworkInterfaces", "()Ljava/util/Enumeration;"); 
			global::java.net.NetworkInterface._isUp10947 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "isUp", "()Z"); 
			global::java.net.NetworkInterface._isLoopback10948 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "isLoopback", "()Z"); 
			global::java.net.NetworkInterface._isPointToPoint10949 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "isPointToPoint", "()Z"); 
			global::java.net.NetworkInterface._supportsMulticast10950 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "supportsMulticast", "()Z"); 
			global::java.net.NetworkInterface._getHardwareAddress10951 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getHardwareAddress", "()[B"); 
			global::java.net.NetworkInterface._getMTU10952 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "getMTU", "()I"); 
			global::java.net.NetworkInterface._isVirtual10953 = @__env.GetMethodID(global::java.net.NetworkInterface.staticClass, "isVirtual", "()Z"); 
		} 
	} 
} 
