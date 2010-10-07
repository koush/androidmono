namespace java.security
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class Provider : java.util.Properties
	{
		internal static global::java.lang.Class staticClass;
		static Provider()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.Provider), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		protected Provider(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Service : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Service()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::java.security.Provider.Service), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::java.security.Provider.Service(@__env);
				}
			}
			protected Service(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _toString13248;
			public override global::java.lang.String toString() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider.Service._toString13248));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._toString13248));
			}
			internal static global::net.sf.jni4net.jni.MethodId _newInstance13249;
			public virtual global::java.lang.Object newInstance(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider.Service._newInstance13249, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._newInstance13249, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getType13250;
			public virtual global::java.lang.String getType() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider.Service._getType13250));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getType13250));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getClassName13251;
			public virtual global::java.lang.String getClassName() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider.Service._getClassName13251));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getClassName13251));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getAlgorithm13252;
			public virtual global::java.lang.String getAlgorithm() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider.Service._getAlgorithm13252));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getAlgorithm13252));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getAttribute13253;
			public virtual global::java.lang.String getAttribute(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider.Service._getAttribute13253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getAttribute13253, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getProvider13254;
			public virtual global::java.security.Provider getProvider() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Provider>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider.Service._getProvider13254));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Provider>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getProvider13254));
			}
			internal static global::net.sf.jni4net.jni.MethodId _supportsParameter13255;
			public virtual bool supportsParameter(java.lang.Object arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this, global::java.security.Provider.Service._supportsParameter13255, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._supportsParameter13255, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Service13256;
			public Service(java.security.Provider arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.util.List arg4, java.util.Map arg5)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(java.security.Provider.Service.staticClass, global::java.security.Provider.Service._Service13256, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::java.security.Provider.Service.staticClass = @__class;
				global::java.security.Provider.Service._toString13248 = @__env.GetMethodID(global::java.security.Provider.Service.staticClass, "toString", "()Ljava/lang/String;");
				global::java.security.Provider.Service._newInstance13249 = @__env.GetMethodID(global::java.security.Provider.Service.staticClass, "newInstance", "(Ljava/lang/Object;)Ljava/lang/Object;");
				global::java.security.Provider.Service._getType13250 = @__env.GetMethodID(global::java.security.Provider.Service.staticClass, "getType", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getClassName13251 = @__env.GetMethodID(global::java.security.Provider.Service.staticClass, "getClassName", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getAlgorithm13252 = @__env.GetMethodID(global::java.security.Provider.Service.staticClass, "getAlgorithm", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getAttribute13253 = @__env.GetMethodID(global::java.security.Provider.Service.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
				global::java.security.Provider.Service._getProvider13254 = @__env.GetMethodID(global::java.security.Provider.Service.staticClass, "getProvider", "()Ljava/security/Provider;");
				global::java.security.Provider.Service._supportsParameter13255 = @__env.GetMethodID(global::java.security.Provider.Service.staticClass, "supportsParameter", "(Ljava/lang/Object;)Z");
				global::java.security.Provider.Service._Service13256 = @__env.GetMethodID(global::java.security.Provider.Service.staticClass, "<init>", "(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _get13257;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._get13257, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._get13257, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _put13258;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._put13258, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._put13258, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getProperty13259;
		public override global::java.lang.String getProperty(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._getProperty13259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._getProperty13259, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString13260;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._toString13260));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._toString13260));
		}
		internal static global::net.sf.jni4net.jni.MethodId _values13261;
		public override global::java.util.Collection values() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._values13261));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Collection>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._values13261));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear13262;
		public override void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.Provider._clear13262);
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.Provider.staticClass, global::java.security.Provider._clear13262);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getName13263;
		public virtual global::java.lang.String getName() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._getName13263));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._getName13263));
		}
		internal static global::net.sf.jni4net.jni.MethodId _entrySet13264;
		public override global::java.util.Set entrySet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._entrySet13264));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._entrySet13264));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putAll13265;
		public override void putAll(java.util.Map arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.Provider._putAll13265, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.Provider.staticClass, global::java.security.Provider._putAll13265, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _load13266;
		public override void load(java.io.InputStream arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.Provider._load13266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.Provider.staticClass, global::java.security.Provider._load13266, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove13267;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._remove13267, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._remove13267, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _elements13268;
		public override global::java.util.Enumeration elements() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._elements13268));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._elements13268));
		}
		internal static global::net.sf.jni4net.jni.MethodId _keys13269;
		public override global::java.util.Enumeration keys() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._keys13269));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Enumeration>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._keys13269));
		}
		internal static global::net.sf.jni4net.jni.MethodId _keySet13270;
		public override global::java.util.Set keySet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._keySet13270));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._keySet13270));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getService13271;
		public virtual global::java.security.Provider.Service getService(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Provider.Service>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._getService13271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.security.Provider.Service>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._getService13271, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getServices13272;
		public virtual global::java.util.Set getServices() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._getServices13272));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._getServices13272));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVersion13273;
		public virtual double getVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::java.security.Provider._getVersion13273);
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::java.security.Provider.staticClass, global::java.security.Provider._getVersion13273);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInfo13274;
		public virtual global::java.lang.String getInfo() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::java.security.Provider._getInfo13274));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::java.security.Provider.staticClass, global::java.security.Provider._getInfo13274));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putService13275;
		protected virtual void putService(java.security.Provider.Service arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.Provider._putService13275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.Provider.staticClass, global::java.security.Provider._putService13275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _removeService13276;
		protected virtual void removeService(java.security.Provider.Service arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::java.security.Provider._removeService13276, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::java.security.Provider.staticClass, global::java.security.Provider._removeService13276, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Provider13277;
		protected Provider(java.lang.String arg0, double arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(java.security.Provider.staticClass, global::java.security.Provider._Provider13277, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::java.security.Provider.staticClass = @__class;
			global::java.security.Provider._get13257 = @__env.GetMethodID(global::java.security.Provider.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._put13258 = @__env.GetMethodID(global::java.security.Provider.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._getProperty13259 = @__env.GetMethodID(global::java.security.Provider.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.security.Provider._toString13260 = @__env.GetMethodID(global::java.security.Provider.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Provider._values13261 = @__env.GetMethodID(global::java.security.Provider.staticClass, "values", "()Ljava/util/Collection;");
			global::java.security.Provider._clear13262 = @__env.GetMethodID(global::java.security.Provider.staticClass, "clear", "()V");
			global::java.security.Provider._getName13263 = @__env.GetMethodID(global::java.security.Provider.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.Provider._entrySet13264 = @__env.GetMethodID(global::java.security.Provider.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.security.Provider._putAll13265 = @__env.GetMethodID(global::java.security.Provider.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.security.Provider._load13266 = @__env.GetMethodID(global::java.security.Provider.staticClass, "load", "(Ljava/io/InputStream;)V");
			global::java.security.Provider._remove13267 = @__env.GetMethodID(global::java.security.Provider.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._elements13268 = @__env.GetMethodID(global::java.security.Provider.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.security.Provider._keys13269 = @__env.GetMethodID(global::java.security.Provider.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.security.Provider._keySet13270 = @__env.GetMethodID(global::java.security.Provider.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.security.Provider._getService13271 = @__env.GetMethodID(global::java.security.Provider.staticClass, "getService", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Provider$Service;");
			global::java.security.Provider._getServices13272 = @__env.GetMethodID(global::java.security.Provider.staticClass, "getServices", "()Ljava/util/Set;");
			global::java.security.Provider._getVersion13273 = @__env.GetMethodID(global::java.security.Provider.staticClass, "getVersion", "()D");
			global::java.security.Provider._getInfo13274 = @__env.GetMethodID(global::java.security.Provider.staticClass, "getInfo", "()Ljava/lang/String;");
			global::java.security.Provider._putService13275 = @__env.GetMethodID(global::java.security.Provider.staticClass, "putService", "(Ljava/security/Provider$Service;)V");
			global::java.security.Provider._removeService13276 = @__env.GetMethodID(global::java.security.Provider.staticClass, "removeService", "(Ljava/security/Provider$Service;)V");
			global::java.security.Provider._Provider13277 = @__env.GetMethodID(global::java.security.Provider.staticClass, "<init>", "(Ljava/lang/String;DLjava/lang/String;)V");
		}
	}
}
