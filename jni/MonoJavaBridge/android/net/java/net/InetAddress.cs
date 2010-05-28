namespace java.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class InetAddress : java.lang.Object, java.io.Serializable
	{ 
		internal static global::java.lang.Class staticClass; 
		static InetAddress() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.net.InetAddress), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _hashCode11739; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallIntMethod(this, global::java.net.InetAddress._hashCode11739); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._hashCode11739); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals11740; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._equals11740, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._equals11740, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAddress11741; 
		public virtual byte[] getAddress() 
		{ 
			if (GetType() == typeof(java.net.InetAddress)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::java.net.InetAddress._getAddress11741)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getAddress11741)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString11742; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.InetAddress._toString11742)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._toString11742)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHostName11743; 
		public virtual global::java.lang.String getHostName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.InetAddress._getHostName11743)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostName11743)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHostAddress11744; 
		public virtual global::java.lang.String getHostAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.InetAddress._getHostAddress11744)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getHostAddress11744)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByName11745; 
		public static global::java.net.InetAddress getByName(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallStaticObjectMethodPtr(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByName11745, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMulticastAddress11746; 
		public virtual bool isMulticastAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isMulticastAddress11746); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMulticastAddress11746); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAnyLocalAddress11747; 
		public virtual bool isAnyLocalAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isAnyLocalAddress11747); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isAnyLocalAddress11747); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLoopbackAddress11748; 
		public virtual bool isLoopbackAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isLoopbackAddress11748); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLoopbackAddress11748); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLinkLocalAddress11749; 
		public virtual bool isLinkLocalAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isLinkLocalAddress11749); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isLinkLocalAddress11749); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSiteLocalAddress11750; 
		public virtual bool isSiteLocalAddress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isSiteLocalAddress11750); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isSiteLocalAddress11750); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMCGlobal11751; 
		public virtual bool isMCGlobal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isMCGlobal11751); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCGlobal11751); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMCNodeLocal11752; 
		public virtual bool isMCNodeLocal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isMCNodeLocal11752); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCNodeLocal11752); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMCLinkLocal11753; 
		public virtual bool isMCLinkLocal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isMCLinkLocal11753); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCLinkLocal11753); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMCSiteLocal11754; 
		public virtual bool isMCSiteLocal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isMCSiteLocal11754); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCSiteLocal11754); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMCOrgLocal11755; 
		public virtual bool isMCOrgLocal() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isMCOrgLocal11755); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isMCOrgLocal11755); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReachable11756; 
		public virtual bool isReachable(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isReachable11756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable11756, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isReachable11757; 
		public virtual bool isReachable(java.net.NetworkInterface arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return @__env.CallBooleanMethod(this, global::java.net.InetAddress._isReachable11757, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._isReachable11757, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCanonicalHostName11758; 
		public virtual global::java.lang.String getCanonicalHostName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(java.net.InetAddress)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.net.InetAddress._getCanonicalHostName11758)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.net.InetAddress.staticClass, global::java.net.InetAddress._getCanonicalHostName11758)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByAddress11759; 
		public static global::java.net.InetAddress getByAddress(java.lang.String arg0, byte[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallStaticObjectMethodPtr(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress11759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getByAddress11760; 
		public static global::java.net.InetAddress getByAddress(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallStaticObjectMethodPtr(java.net.InetAddress.staticClass, global::java.net.InetAddress._getByAddress11760, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getAllByName11761; 
		public static global::java.net.InetAddress[] getAllByName(java.lang.String arg0) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(java.net.InetAddress.staticClass, global::java.net.InetAddress._getAllByName11761, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLocalHost11762; 
		public static global::java.net.InetAddress getLocalHost() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.net.InetAddress>(@__env, @__env.CallStaticObjectMethodPtr(java.net.InetAddress.staticClass, global::java.net.InetAddress._getLocalHost11762)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::java.net.InetAddress.staticClass = @__class; 
			global::java.net.InetAddress._hashCode11739 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "hashCode", "()I"); 
			global::java.net.InetAddress._equals11740 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::java.net.InetAddress._getAddress11741 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "getAddress", "()[B"); 
			global::java.net.InetAddress._toString11742 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "toString", "()Ljava/lang/String;"); 
			global::java.net.InetAddress._getHostName11743 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "getHostName", "()Ljava/lang/String;"); 
			global::java.net.InetAddress._getHostAddress11744 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "getHostAddress", "()Ljava/lang/String;"); 
			global::java.net.InetAddress._getByName11745 = @__env.GetStaticMethodID(global::java.net.InetAddress.staticClass, "getByName", "(Ljava/lang/String;)Ljava/net/InetAddress;"); 
			global::java.net.InetAddress._isMulticastAddress11746 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMulticastAddress", "()Z"); 
			global::java.net.InetAddress._isAnyLocalAddress11747 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isAnyLocalAddress", "()Z"); 
			global::java.net.InetAddress._isLoopbackAddress11748 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isLoopbackAddress", "()Z"); 
			global::java.net.InetAddress._isLinkLocalAddress11749 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isLinkLocalAddress", "()Z"); 
			global::java.net.InetAddress._isSiteLocalAddress11750 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isSiteLocalAddress", "()Z"); 
			global::java.net.InetAddress._isMCGlobal11751 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMCGlobal", "()Z"); 
			global::java.net.InetAddress._isMCNodeLocal11752 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMCNodeLocal", "()Z"); 
			global::java.net.InetAddress._isMCLinkLocal11753 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMCLinkLocal", "()Z"); 
			global::java.net.InetAddress._isMCSiteLocal11754 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMCSiteLocal", "()Z"); 
			global::java.net.InetAddress._isMCOrgLocal11755 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isMCOrgLocal", "()Z"); 
			global::java.net.InetAddress._isReachable11756 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isReachable", "(I)Z"); 
			global::java.net.InetAddress._isReachable11757 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "isReachable", "(Ljava/net/NetworkInterface;II)Z"); 
			global::java.net.InetAddress._getCanonicalHostName11758 = @__env.GetMethodID(global::java.net.InetAddress.staticClass, "getCanonicalHostName", "()Ljava/lang/String;"); 
			global::java.net.InetAddress._getByAddress11759 = @__env.GetStaticMethodID(global::java.net.InetAddress.staticClass, "getByAddress", "(Ljava/lang/String;[B)Ljava/net/InetAddress;"); 
			global::java.net.InetAddress._getByAddress11760 = @__env.GetStaticMethodID(global::java.net.InetAddress.staticClass, "getByAddress", "([B)Ljava/net/InetAddress;"); 
			global::java.net.InetAddress._getAllByName11761 = @__env.GetStaticMethodID(global::java.net.InetAddress.staticClass, "getAllByName", "(Ljava/lang/String;)[Ljava/net/InetAddress;"); 
			global::java.net.InetAddress._getLocalHost11762 = @__env.GetStaticMethodID(global::java.net.InetAddress.staticClass, "getLocalHost", "()Ljava/net/InetAddress;"); 
		} 
	} 
} 
