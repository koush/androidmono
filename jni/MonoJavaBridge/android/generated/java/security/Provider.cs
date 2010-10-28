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
			internal static global::MonoJavaBridge.MethodId _toString23261;
			public override global::java.lang.String toString()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._toString23261)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._toString23261)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _newInstance23262;
			public virtual global::java.lang.Object newInstance(java.lang.Object arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._newInstance23262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._newInstance23262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			}
			public new global::java.lang.String Type
			{
				get
				{
					return getType();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getType23263;
			public virtual global::java.lang.String getType()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getType23263)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getType23263)) as java.lang.String;
			}
			public new global::java.lang.String ClassName
			{
				get
				{
					return getClassName();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getClassName23264;
			public virtual global::java.lang.String getClassName()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getClassName23264)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getClassName23264)) as java.lang.String;
			}
			public new global::java.lang.String Algorithm
			{
				get
				{
					return getAlgorithm();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getAlgorithm23265;
			public virtual global::java.lang.String getAlgorithm()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getAlgorithm23265)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getAlgorithm23265)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getAttribute23266;
			public virtual global::java.lang.String getAttribute(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getAttribute23266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getAttribute23266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			public new global::java.security.Provider Provider
			{
				get
				{
					return getProvider();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getProvider23267;
			public virtual global::java.security.Provider getProvider()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getProvider23267)) as java.security.Provider;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getProvider23267)) as java.security.Provider;
			}
			internal static global::MonoJavaBridge.MethodId _supportsParameter23268;
			public virtual bool supportsParameter(java.lang.Object arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Provider.Service._supportsParameter23268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._supportsParameter23268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _Service23269;
			public Service(java.security.Provider arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.util.List arg4, java.util.Map arg5) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Provider.Service.staticClass, global::java.security.Provider.Service._Service23269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				Init(@__env, handle);
			}
			static Service()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.Provider.Service.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider$Service"));
				global::java.security.Provider.Service._toString23261 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "toString", "()Ljava/lang/String;");
				global::java.security.Provider.Service._newInstance23262 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "newInstance", "(Ljava/lang/Object;)Ljava/lang/Object;");
				global::java.security.Provider.Service._getType23263 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getType", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getClassName23264 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getClassName", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getAlgorithm23265 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getAlgorithm", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getAttribute23266 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
				global::java.security.Provider.Service._getProvider23267 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getProvider", "()Ljava/security/Provider;");
				global::java.security.Provider.Service._supportsParameter23268 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "supportsParameter", "(Ljava/lang/Object;)Z");
				global::java.security.Provider.Service._Service23269 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "<init>", "(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _get23270;
		public override global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._get23270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._get23270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put23271;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._put23271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._put23271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty23272;
		public override global::java.lang.String getProperty(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getProperty23272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getProperty23272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString23273;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._toString23273)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._toString23273)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _values23274;
		public override global::java.util.Collection values()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._values23274)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._values23274)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clear23275;
		public override void clear()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._clear23275);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._clear23275);
		}
		internal static global::MonoJavaBridge.MethodId _getName23276;
		public virtual global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getName23276)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getName23276)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _entrySet23277;
		public override global::java.util.Set entrySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._entrySet23277)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._entrySet23277)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll23278;
		public override void putAll(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._putAll23278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._putAll23278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _load23279;
		public override void load(java.io.InputStream arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._load23279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._load23279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove23280;
		public override global::java.lang.Object remove(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._remove23280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._remove23280, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements23281;
		public override global::java.util.Enumeration elements()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._elements23281)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._elements23281)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys23282;
		public override global::java.util.Enumeration keys()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._keys23282)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._keys23282)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keySet23283;
		public override global::java.util.Set keySet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._keySet23283)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._keySet23283)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getService23284;
		public virtual global::java.security.Provider.Service getService(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getService23284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Provider.Service;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getService23284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Provider.Service;
		}
		internal static global::MonoJavaBridge.MethodId _getServices23285;
		public virtual global::java.util.Set getServices()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getServices23285)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getServices23285)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion23286;
		public virtual double getVersion()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.security.Provider._getVersion23286);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getVersion23286);
		}
		internal static global::MonoJavaBridge.MethodId _getInfo23287;
		public virtual global::java.lang.String getInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getInfo23287)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getInfo23287)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _putService23288;
		protected virtual void putService(java.security.Provider.Service arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._putService23288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._putService23288, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeService23289;
		protected virtual void removeService(java.security.Provider.Service arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._removeService23289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._removeService23289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Provider23290;
		protected Provider(java.lang.String arg0, double arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Provider.staticClass, global::java.security.Provider._Provider23290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static Provider()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Provider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider"));
			global::java.security.Provider._get23270 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._put23271 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._getProperty23272 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.security.Provider._toString23273 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Provider._values23274 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "values", "()Ljava/util/Collection;");
			global::java.security.Provider._clear23275 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "clear", "()V");
			global::java.security.Provider._getName23276 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.Provider._entrySet23277 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.security.Provider._putAll23278 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.security.Provider._load23279 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "load", "(Ljava/io/InputStream;)V");
			global::java.security.Provider._remove23280 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._elements23281 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.security.Provider._keys23282 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.security.Provider._keySet23283 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.security.Provider._getService23284 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getService", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Provider$Service;");
			global::java.security.Provider._getServices23285 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getServices", "()Ljava/util/Set;");
			global::java.security.Provider._getVersion23286 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getVersion", "()D");
			global::java.security.Provider._getInfo23287 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getInfo", "()Ljava/lang/String;");
			global::java.security.Provider._putService23288 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "putService", "(Ljava/security/Provider$Service;)V");
			global::java.security.Provider._removeService23289 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "removeService", "(Ljava/security/Provider$Service;)V");
			global::java.security.Provider._Provider23290 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "<init>", "(Ljava/lang/String;DLjava/lang/String;)V");
		}
		internal static void InitJNI()
		{
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
		internal static void InitJNI()
		{
		}
	}
}
