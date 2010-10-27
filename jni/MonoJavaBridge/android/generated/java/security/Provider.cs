namespace java.security
{
	[global::MonoJavaBridge.JavaClass(typeof(global::java.security.Provider_))]
	public abstract partial class Provider : java.util.Properties
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Provider()
		{
			InitJNI();
		}
		protected Provider(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Service : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Service()
			{
				InitJNI();
			}
			protected Service(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _toString23260;
			public override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._toString23260)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._toString23260)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _newInstance23261;
			public virtual global::java.lang.Object newInstance(java.lang.Object arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._newInstance23261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._newInstance23261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			}
			public new global::java.lang.String Type
			{
				get
				{
					return getType();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getType23262;
			public virtual global::java.lang.String getType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getType23262)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getType23262)) as java.lang.String;
			}
			public new global::java.lang.String ClassName
			{
				get
				{
					return getClassName();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getClassName23263;
			public virtual global::java.lang.String getClassName()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getClassName23263)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getClassName23263)) as java.lang.String;
			}
			public new global::java.lang.String Algorithm
			{
				get
				{
					return getAlgorithm();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getAlgorithm23264;
			public virtual global::java.lang.String getAlgorithm()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getAlgorithm23264)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getAlgorithm23264)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getAttribute23265;
			public virtual global::java.lang.String getAttribute(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getAttribute23265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getAttribute23265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			public new global::java.security.Provider Provider
			{
				get
				{
					return getProvider();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getProvider23266;
			public virtual global::java.security.Provider getProvider()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getProvider23266)) as java.security.Provider;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getProvider23266)) as java.security.Provider;
			}
			internal static global::MonoJavaBridge.MethodId _supportsParameter23267;
			public virtual bool supportsParameter(java.lang.Object arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Provider.Service._supportsParameter23267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._supportsParameter23267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _Service23268;
			public Service(java.security.Provider arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.util.List arg4, java.util.Map arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Provider.Service.staticClass, global::java.security.Provider.Service._Service23268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.Provider.Service.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider$Service"));
				global::java.security.Provider.Service._toString23260 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "toString", "()Ljava/lang/String;");
				global::java.security.Provider.Service._newInstance23261 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "newInstance", "(Ljava/lang/Object;)Ljava/lang/Object;");
				global::java.security.Provider.Service._getType23262 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getType", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getClassName23263 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getClassName", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getAlgorithm23264 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getAlgorithm", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getAttribute23265 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
				global::java.security.Provider.Service._getProvider23266 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getProvider", "()Ljava/security/Provider;");
				global::java.security.Provider.Service._supportsParameter23267 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "supportsParameter", "(Ljava/lang/Object;)Z");
				global::java.security.Provider.Service._Service23268 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "<init>", "(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _get23269;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._get23269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._get23269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put23270;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._put23270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._put23270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty23271;
		public override global::java.lang.String getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getProperty23271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getProperty23271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString23272;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._toString23272)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._toString23272)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _values23273;
		public override global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._values23273)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._values23273)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clear23274;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._clear23274);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._clear23274);
		}
		internal static global::MonoJavaBridge.MethodId _getName23275;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getName23275)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getName23275)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _entrySet23276;
		public override global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._entrySet23276)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._entrySet23276)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll23277;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._putAll23277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._putAll23277, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _load23278;
		public override void load(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._load23278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._load23278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove23279;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._remove23279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._remove23279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements23280;
		public override global::java.util.Enumeration elements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._elements23280)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._elements23280)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys23281;
		public override global::java.util.Enumeration keys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._keys23281)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._keys23281)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keySet23282;
		public override global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._keySet23282)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._keySet23282)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getService23283;
		public virtual global::java.security.Provider.Service getService(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getService23283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Provider.Service;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getService23283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Provider.Service;
		}
		internal static global::MonoJavaBridge.MethodId _getServices23284;
		public virtual global::java.util.Set getServices()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getServices23284)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getServices23284)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion23285;
		public virtual double getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.security.Provider._getVersion23285);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getVersion23285);
		}
		internal static global::MonoJavaBridge.MethodId _getInfo23286;
		public virtual global::java.lang.String getInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getInfo23286)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getInfo23286)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _putService23287;
		protected virtual void putService(java.security.Provider.Service arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._putService23287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._putService23287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeService23288;
		protected virtual void removeService(java.security.Provider.Service arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._removeService23288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._removeService23288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Provider23289;
		protected Provider(java.lang.String arg0, double arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Provider.staticClass, global::java.security.Provider._Provider23289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Provider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider"));
			global::java.security.Provider._get23269 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._put23270 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._getProperty23271 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.security.Provider._toString23272 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Provider._values23273 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "values", "()Ljava/util/Collection;");
			global::java.security.Provider._clear23274 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "clear", "()V");
			global::java.security.Provider._getName23275 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.Provider._entrySet23276 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.security.Provider._putAll23277 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.security.Provider._load23278 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "load", "(Ljava/io/InputStream;)V");
			global::java.security.Provider._remove23279 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._elements23280 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.security.Provider._keys23281 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.security.Provider._keySet23282 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.security.Provider._getService23283 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getService", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Provider$Service;");
			global::java.security.Provider._getServices23284 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getServices", "()Ljava/util/Set;");
			global::java.security.Provider._getVersion23285 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getVersion", "()D");
			global::java.security.Provider._getInfo23286 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getInfo", "()Ljava/lang/String;");
			global::java.security.Provider._putService23287 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "putService", "(Ljava/security/Provider$Service;)V");
			global::java.security.Provider._removeService23288 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "removeService", "(Ljava/security/Provider$Service;)V");
			global::java.security.Provider._Provider23289 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "<init>", "(Ljava/lang/String;DLjava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Provider))]
	internal sealed partial class Provider_ : java.security.Provider
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Provider_()
		{
			InitJNI();
		}
		internal Provider_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Provider_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider"));
		}
	}
}
