namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Provider_))]
	public abstract partial class Provider : java.util.Properties
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Provider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Service : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Service(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override global::java.lang.String toString()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Provider.Service.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.Provider.Service._m0) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual global::java.lang.Object newInstance(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Provider.Service.staticClass, "newInstance", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.security.Provider.Service._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
			}
			public new global::java.lang.String Type
			{
				get
				{
					return getType();
				}
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual global::java.lang.String getType()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Provider.Service.staticClass, "getType", "()Ljava/lang/String;", ref global::java.security.Provider.Service._m2) as java.lang.String;
			}
			public new global::java.lang.String ClassName
			{
				get
				{
					return getClassName();
				}
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual global::java.lang.String getClassName()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Provider.Service.staticClass, "getClassName", "()Ljava/lang/String;", ref global::java.security.Provider.Service._m3) as java.lang.String;
			}
			public new global::java.lang.String Algorithm
			{
				get
				{
					return getAlgorithm();
				}
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual global::java.lang.String getAlgorithm()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Provider.Service.staticClass, "getAlgorithm", "()Ljava/lang/String;", ref global::java.security.Provider.Service._m4) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual global::java.lang.String getAttribute(java.lang.String arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Provider.Service.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.security.Provider.Service._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
			}
			public new global::java.security.Provider Provider
			{
				get
				{
					return getProvider();
				}
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual global::java.security.Provider getProvider()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Provider.Service.staticClass, "getProvider", "()Ljava/security/Provider;", ref global::java.security.Provider.Service._m6) as java.security.Provider;
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual bool supportsParameter(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.security.Provider.Service.staticClass, "supportsParameter", "(Ljava/lang/Object;)Z", ref global::java.security.Provider.Service._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public Service(java.security.Provider arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.util.List arg4, java.util.Map arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::java.security.Provider.Service._m8.native == global::System.IntPtr.Zero)
					global::java.security.Provider.Service._m8 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "<init>", "(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Provider.Service.staticClass, global::java.security.Provider.Service._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				Init(@__env, handle);
			}
			static Service()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.Provider.Service.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider$Service"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Provider.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.security.Provider._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Provider.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.security.Provider._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::java.lang.String getProperty(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Provider.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;", ref global::java.security.Provider._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Provider.staticClass, "toString", "()Ljava/lang/String;", ref global::java.security.Provider._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override global::java.util.Collection values()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Collection>(this, global::java.security.Provider.staticClass, "values", "()Ljava/util/Collection;", ref global::java.security.Provider._m4) as java.util.Collection;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void clear()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Provider.staticClass, "clear", "()V", ref global::java.security.Provider._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Provider.staticClass, "getName", "()Ljava/lang/String;", ref global::java.security.Provider._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.util.Set entrySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.Provider.staticClass, "entrySet", "()Ljava/util/Set;", ref global::java.security.Provider._m7) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Provider.staticClass, "putAll", "(Ljava/util/Map;)V", ref global::java.security.Provider._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override void load(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Provider.staticClass, "load", "(Ljava/io/InputStream;)V", ref global::java.security.Provider._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Provider.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.security.Provider._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override global::java.util.Enumeration elements()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.Provider.staticClass, "elements", "()Ljava/util/Enumeration;", ref global::java.security.Provider._m11) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override global::java.util.Enumeration keys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Enumeration>(this, global::java.security.Provider.staticClass, "keys", "()Ljava/util/Enumeration;", ref global::java.security.Provider._m12) as java.util.Enumeration;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override global::java.util.Set keySet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.Provider.staticClass, "keySet", "()Ljava/util/Set;", ref global::java.security.Provider._m13) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::java.security.Provider.Service getService(java.lang.String arg0, java.lang.String arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.security.Provider.staticClass, "getService", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Provider$Service;", ref global::java.security.Provider._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.security.Provider.Service;
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.util.Set getServices()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Set>(this, global::java.security.Provider.staticClass, "getServices", "()Ljava/util/Set;", ref global::java.security.Provider._m15) as java.util.Set;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual double getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.security.Provider.staticClass, "getVersion", "()D", ref global::java.security.Provider._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual global::java.lang.String getInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.security.Provider.staticClass, "getInfo", "()Ljava/lang/String;", ref global::java.security.Provider._m17) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected virtual void putService(java.security.Provider.Service arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Provider.staticClass, "putService", "(Ljava/security/Provider$Service;)V", ref global::java.security.Provider._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		protected virtual void removeService(java.security.Provider.Service arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.security.Provider.staticClass, "removeService", "(Ljava/security/Provider$Service;)V", ref global::java.security.Provider._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		protected Provider(java.lang.String arg0, double arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.security.Provider._m20.native == global::System.IntPtr.Zero)
				global::java.security.Provider._m20 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "<init>", "(Ljava/lang/String;DLjava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Provider.staticClass, global::java.security.Provider._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Provider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Provider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Provider))]
	internal sealed partial class Provider_ : java.security.Provider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Provider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static Provider_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Provider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider"));
		}
	}
}
