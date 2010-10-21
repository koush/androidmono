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
			internal static global::MonoJavaBridge.MethodId _toString23142;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._toString23142)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._toString23142)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _newInstance23143;
			public virtual global::java.lang.Object newInstance(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._newInstance23143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._newInstance23143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			}
			public new global::java.lang.String Type
			{
				get
				{
					return getType();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getType23144;
			public virtual global::java.lang.String getType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getType23144)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getType23144)) as java.lang.String;
			}
			public new global::java.lang.String ClassName
			{
				get
				{
					return getClassName();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getClassName23145;
			public virtual global::java.lang.String getClassName() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getClassName23145)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getClassName23145)) as java.lang.String;
			}
			public new global::java.lang.String Algorithm
			{
				get
				{
					return getAlgorithm();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getAlgorithm23146;
			public virtual global::java.lang.String getAlgorithm() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getAlgorithm23146)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getAlgorithm23146)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getAttribute23147;
			public virtual global::java.lang.String getAttribute(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getAttribute23147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getAttribute23147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			public new global::java.security.Provider Provider
			{
				get
				{
					return getProvider();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getProvider23148;
			public virtual global::java.security.Provider getProvider() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getProvider23148)) as java.security.Provider;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getProvider23148)) as java.security.Provider;
			}
			internal static global::MonoJavaBridge.MethodId _supportsParameter23149;
			public virtual bool supportsParameter(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Provider.Service._supportsParameter23149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._supportsParameter23149, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _Service23150;
			public Service(java.security.Provider arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.util.List arg4, java.util.Map arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Provider.Service.staticClass, global::java.security.Provider.Service._Service23150, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.Provider.Service.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider$Service"));
				global::java.security.Provider.Service._toString23142 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "toString", "()Ljava/lang/String;");
				global::java.security.Provider.Service._newInstance23143 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "newInstance", "(Ljava/lang/Object;)Ljava/lang/Object;");
				global::java.security.Provider.Service._getType23144 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getType", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getClassName23145 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getClassName", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getAlgorithm23146 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getAlgorithm", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getAttribute23147 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
				global::java.security.Provider.Service._getProvider23148 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getProvider", "()Ljava/security/Provider;");
				global::java.security.Provider.Service._supportsParameter23149 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "supportsParameter", "(Ljava/lang/Object;)Z");
				global::java.security.Provider.Service._Service23150 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "<init>", "(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _get23151;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._get23151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._get23151, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put23152;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._put23152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._put23152, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty23153;
		public override global::java.lang.String getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getProperty23153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getProperty23153, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString23154;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._toString23154)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._toString23154)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _values23155;
		public override global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._values23155)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._values23155)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clear23156;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._clear23156);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._clear23156);
		}
		internal static global::MonoJavaBridge.MethodId _getName23157;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getName23157)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getName23157)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _entrySet23158;
		public override global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._entrySet23158)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._entrySet23158)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll23159;
		public override void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._putAll23159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._putAll23159, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _load23160;
		public override void load(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._load23160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._load23160, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove23161;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._remove23161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._remove23161, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements23162;
		public override global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._elements23162)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._elements23162)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys23163;
		public override global::java.util.Enumeration keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._keys23163)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._keys23163)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keySet23164;
		public override global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._keySet23164)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._keySet23164)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getService23165;
		public virtual global::java.security.Provider.Service getService(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getService23165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Provider.Service;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getService23165, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Provider.Service;
		}
		internal static global::MonoJavaBridge.MethodId _getServices23166;
		public virtual global::java.util.Set getServices() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getServices23166)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getServices23166)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion23167;
		public virtual double getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.security.Provider._getVersion23167);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getVersion23167);
		}
		internal static global::MonoJavaBridge.MethodId _getInfo23168;
		public virtual global::java.lang.String getInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getInfo23168)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getInfo23168)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _putService23169;
		protected virtual void putService(java.security.Provider.Service arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._putService23169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._putService23169, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeService23170;
		protected virtual void removeService(java.security.Provider.Service arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._removeService23170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._removeService23170, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Provider23171;
		protected Provider(java.lang.String arg0, double arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Provider.staticClass, global::java.security.Provider._Provider23171, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Provider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider"));
			global::java.security.Provider._get23151 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._put23152 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._getProperty23153 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.security.Provider._toString23154 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Provider._values23155 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "values", "()Ljava/util/Collection;");
			global::java.security.Provider._clear23156 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "clear", "()V");
			global::java.security.Provider._getName23157 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.Provider._entrySet23158 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.security.Provider._putAll23159 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.security.Provider._load23160 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "load", "(Ljava/io/InputStream;)V");
			global::java.security.Provider._remove23161 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._elements23162 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.security.Provider._keys23163 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.security.Provider._keySet23164 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.security.Provider._getService23165 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getService", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Provider$Service;");
			global::java.security.Provider._getServices23166 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getServices", "()Ljava/util/Set;");
			global::java.security.Provider._getVersion23167 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getVersion", "()D");
			global::java.security.Provider._getInfo23168 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getInfo", "()Ljava/lang/String;");
			global::java.security.Provider._putService23169 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "putService", "(Ljava/security/Provider$Service;)V");
			global::java.security.Provider._removeService23170 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "removeService", "(Ljava/security/Provider$Service;)V");
			global::java.security.Provider._Provider23171 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "<init>", "(Ljava/lang/String;DLjava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.security.Provider))]
	public sealed partial class Provider_ : java.security.Provider
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
