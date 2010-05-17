namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class InetAddress : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static InetAddress() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(java.net.InetAddress), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::java.net.InetAddress(@__env); 
			} 
		} 
		protected InetAddress(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode10911; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallIntMethod(this, _hashCode10911); 
			else 
				return @__env.CallNonVirtualIntMethod(this, java.net.InetAddress.staticClass, _hashCode10911); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals10912; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _equals10912, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _equals10912, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAddress10913; 
		public virtual byte[] getAddress() 
		{ 
			if (GetType() == typeof(java.net.InetAddress)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getAddress10913)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.InetAddress.staticClass, _getAddress10913)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString10914; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString10914)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.InetAddress.staticClass, _toString10914)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHostName10915; 
		public virtual java.lang.String getHostName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getHostName10915)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.InetAddress.staticClass, _getHostName10915)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHostAddress10916; 
		public virtual java.lang.String getHostAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getHostAddress10916)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.InetAddress.staticClass, _getHostAddress10916)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByName10917; 
		public static java.net.InetAddress getByName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallStaticObjectMethodPtr(java.net.InetAddress.staticClass, _getByName10917, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMulticastAddress10918; 
		public virtual bool isMulticastAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isMulticastAddress10918); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isMulticastAddress10918); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAnyLocalAddress10919; 
		public virtual bool isAnyLocalAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isAnyLocalAddress10919); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isAnyLocalAddress10919); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLoopbackAddress10920; 
		public virtual bool isLoopbackAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isLoopbackAddress10920); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isLoopbackAddress10920); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLinkLocalAddress10921; 
		public virtual bool isLinkLocalAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isLinkLocalAddress10921); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isLinkLocalAddress10921); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSiteLocalAddress10922; 
		public virtual bool isSiteLocalAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isSiteLocalAddress10922); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isSiteLocalAddress10922); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMCGlobal10923; 
		public virtual bool isMCGlobal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isMCGlobal10923); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isMCGlobal10923); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMCNodeLocal10924; 
		public virtual bool isMCNodeLocal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isMCNodeLocal10924); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isMCNodeLocal10924); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMCLinkLocal10925; 
		public virtual bool isMCLinkLocal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isMCLinkLocal10925); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isMCLinkLocal10925); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMCSiteLocal10926; 
		public virtual bool isMCSiteLocal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isMCSiteLocal10926); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isMCSiteLocal10926); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMCOrgLocal10927; 
		public virtual bool isMCOrgLocal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isMCOrgLocal10927); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isMCOrgLocal10927); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReachable10928; 
		public virtual bool isReachable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isReachable10928, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isReachable10928, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReachable10929; 
		public virtual bool isReachable(java.net.NetworkInterface arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, _isReachable10929, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, java.net.InetAddress.staticClass, _isReachable10929, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCanonicalHostName10930; 
		public virtual java.lang.String getCanonicalHostName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getCanonicalHostName10930)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, java.net.InetAddress.staticClass, _getCanonicalHostName10930)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByAddress10931; 
		public static java.net.InetAddress getByAddress(java.lang.String arg0, byte[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallStaticObjectMethodPtr(java.net.InetAddress.staticClass, _getByAddress10931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByAddress10932; 
		public static java.net.InetAddress getByAddress(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallStaticObjectMethodPtr(java.net.InetAddress.staticClass, _getByAddress10932, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllByName10933; 
		public static java.net.InetAddress[] getAllByName(java.lang.String arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.net.InetAddress.staticClass, _getAllByName10933, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalHost10934; 
		public static java.net.InetAddress getLocalHost() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallStaticObjectMethodPtr(java.net.InetAddress.staticClass, _getLocalHost10934)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.InetAddress.staticClass = @__class; 
			global::java.net.InetAddress._hashCode10911 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "hashCode", "()I"); 
			global::java.net.InetAddress._equals10912 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.net.InetAddress._getAddress10913 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "getAddress", "()[B"); 
			global::java.net.InetAddress._toString10914 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.InetAddress._getHostName10915 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "getHostName", "()Ljava/lang/String;"); 
			global::java.net.InetAddress._getHostAddress10916 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "getHostAddress", "()Ljava/lang/String;"); 
			global::java.net.InetAddress._getByName10917 = @__env.GetStaticMethodID(global::java.net.InetAddress.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;"); 
			global::java.net.InetAddress._isMulticastAddress10918 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMulticastAddress", "()Z"); 
			global::java.net.InetAddress._isAnyLocalAddress10919 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isAnyLocalAddress", "()Z"); 
			global::java.net.InetAddress._isLoopbackAddress10920 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isLoopbackAddress", "()Z"); 
			global::java.net.InetAddress._isLinkLocalAddress10921 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isLinkLocalAddress", "()Z"); 
			global::java.net.InetAddress._isSiteLocalAddress10922 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isSiteLocalAddress", "()Z"); 
			global::java.net.InetAddress._isMCGlobal10923 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMCGlobal", "()Z"); 
			global::java.net.InetAddress._isMCNodeLocal10924 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMCNodeLocal", "()Z"); 
			global::java.net.InetAddress._isMCLinkLocal10925 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMCLinkLocal", "()Z"); 
			global::java.net.InetAddress._isMCSiteLocal10926 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMCSiteLocal", "()Z"); 
			global::java.net.InetAddress._isMCOrgLocal10927 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMCOrgLocal", "()Z"); 
			global::java.net.InetAddress._isReachable10928 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isReachable", "(I)Z"); 
			global::java.net.InetAddress._isReachable10929 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isReachable", "(Ljava/net/NetworkInterface;II)Z"); 
			global::java.net.InetAddress._getCanonicalHostName10930 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "getCanonicalHostName", "()Ljava/lang/String;"); 
			global::java.net.InetAddress._getByAddress10931 = @__env.GetStaticMethodID(global::java.net.InetAddress.staticClass, "getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;"); 
			global::java.net.InetAddress._getByAddress10932 = @__env.GetStaticMethodID(global::java.net.InetAddress.staticClass, "getByAddress", "([B)Ljava/net/InetAddress;"); 
			global::java.net.InetAddress._getAllByName10933 = @__env.GetStaticMethodID(global::java.net.InetAddress.staticClass, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;"); 
			global::java.net.InetAddress._getLocalHost10934 = @__env.GetStaticMethodID(global::java.net.InetAddress.staticClass, "getLocalHost", "()Ljava/net/InetAddress;"); 
		} 
	} 
} 
