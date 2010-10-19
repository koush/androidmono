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
			internal static global::MonoJavaBridge.MethodId _toString17542;
			public override global::java.lang.String toString() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._toString17542)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._toString17542)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _newInstance17543;
			public virtual global::java.lang.Object newInstance(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._newInstance17543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._newInstance17543, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			}
			public new global::java.lang.String Type
			{
				get
				{
					return getType();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getType17544;
			public virtual global::java.lang.String getType() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getType17544)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getType17544)) as java.lang.String;
			}
			public new global::java.lang.String ClassName
			{
				get
				{
					return getClassName();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getClassName17545;
			public virtual global::java.lang.String getClassName() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getClassName17545)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getClassName17545)) as java.lang.String;
			}
			public new global::java.lang.String Algorithm
			{
				get
				{
					return getAlgorithm();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getAlgorithm17546;
			public virtual global::java.lang.String getAlgorithm() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getAlgorithm17546)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getAlgorithm17546)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getAttribute17547;
			public virtual global::java.lang.String getAttribute(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getAttribute17547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getAttribute17547, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			public new global::java.security.Provider Provider
			{
				get
				{
					return getProvider();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getProvider17548;
			public virtual global::java.security.Provider getProvider() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider.Service._getProvider17548)) as java.security.Provider;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._getProvider17548)) as java.security.Provider;
			}
			internal static global::MonoJavaBridge.MethodId _supportsParameter17549;
			public virtual bool supportsParameter(java.lang.Object arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::java.security.Provider.Service._supportsParameter17549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.security.Provider.Service.staticClass, global::java.security.Provider.Service._supportsParameter17549, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _Service17550;
			public Service(java.security.Provider arg0, java.lang.String arg1, java.lang.String arg2, java.lang.String arg3, java.util.List arg4, java.util.Map arg5)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Provider.Service.staticClass, global::java.security.Provider.Service._Service17550, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::java.security.Provider.Service.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider$Service"));
				global::java.security.Provider.Service._toString17542 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "toString", "()Ljava/lang/String;");
				global::java.security.Provider.Service._newInstance17543 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "newInstance", "(Ljava/lang/Object;)Ljava/lang/Object;");
				global::java.security.Provider.Service._getType17544 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getType", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getClassName17545 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getClassName", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getAlgorithm17546 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getAlgorithm", "()Ljava/lang/String;");
				global::java.security.Provider.Service._getAttribute17547 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getAttribute", "(Ljava/lang/String;)Ljava/lang/String;");
				global::java.security.Provider.Service._getProvider17548 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "getProvider", "()Ljava/security/Provider;");
				global::java.security.Provider.Service._supportsParameter17549 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "supportsParameter", "(Ljava/lang/Object;)Z");
				global::java.security.Provider.Service._Service17550 = @__env.GetMethodIDNoThrow(global::java.security.Provider.Service.staticClass, "<init>", "(Ljava/security/Provider;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/util/List;Ljava/util/Map;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _get17551;
		public override global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._get17551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._get17551, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _put17552;
		public override global::java.lang.Object put(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._put17552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._put17552, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getProperty17553;
		public override global::java.lang.String getProperty(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getProperty17553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getProperty17553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _toString17554;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._toString17554)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._toString17554)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _values17555;
		public override global::java.util.Collection values() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._values17555)) as java.util.Collection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Collection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._values17555)) as java.util.Collection;
		}
		internal static global::MonoJavaBridge.MethodId _clear17556;
		public override void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._clear17556);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._clear17556);
		}
		internal static global::MonoJavaBridge.MethodId _getName17557;
		public virtual global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getName17557)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getName17557)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _entrySet17558;
		public override global::java.util.Set entrySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._entrySet17558)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._entrySet17558)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _putAll17559;
		public override void putAll(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._putAll17559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._putAll17559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _load17560;
		public override void load(java.io.InputStream arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._load17560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._load17560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove17561;
		public override global::java.lang.Object remove(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._remove17561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._remove17561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _elements17562;
		public override global::java.util.Enumeration elements() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._elements17562)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._elements17562)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keys17563;
		public override global::java.util.Enumeration keys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._keys17563)) as java.util.Enumeration;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Enumeration>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._keys17563)) as java.util.Enumeration;
		}
		internal static global::MonoJavaBridge.MethodId _keySet17564;
		public override global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._keySet17564)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._keySet17564)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getService17565;
		public virtual global::java.security.Provider.Service getService(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getService17565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Provider.Service;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getService17565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.security.Provider.Service;
		}
		internal static global::MonoJavaBridge.MethodId _getServices17566;
		public virtual global::java.util.Set getServices() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getServices17566)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getServices17566)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _getVersion17567;
		public virtual double getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.security.Provider._getVersion17567);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getVersion17567);
		}
		internal static global::MonoJavaBridge.MethodId _getInfo17568;
		public virtual global::java.lang.String getInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.security.Provider._getInfo17568)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._getInfo17568)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _putService17569;
		protected virtual void putService(java.security.Provider.Service arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._putService17569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._putService17569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _removeService17570;
		protected virtual void removeService(java.security.Provider.Service arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.security.Provider._removeService17570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.security.Provider.staticClass, global::java.security.Provider._removeService17570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _Provider17571;
		protected Provider(java.lang.String arg0, double arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.security.Provider.staticClass, global::java.security.Provider._Provider17571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.security.Provider.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/security/Provider"));
			global::java.security.Provider._get17551 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._put17552 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "put", "(Ljava/lang/Object;Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._getProperty17553 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getProperty", "(Ljava/lang/String;)Ljava/lang/String;");
			global::java.security.Provider._toString17554 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "toString", "()Ljava/lang/String;");
			global::java.security.Provider._values17555 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "values", "()Ljava/util/Collection;");
			global::java.security.Provider._clear17556 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "clear", "()V");
			global::java.security.Provider._getName17557 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getName", "()Ljava/lang/String;");
			global::java.security.Provider._entrySet17558 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "entrySet", "()Ljava/util/Set;");
			global::java.security.Provider._putAll17559 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "putAll", "(Ljava/util/Map;)V");
			global::java.security.Provider._load17560 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "load", "(Ljava/io/InputStream;)V");
			global::java.security.Provider._remove17561 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "remove", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.security.Provider._elements17562 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "elements", "()Ljava/util/Enumeration;");
			global::java.security.Provider._keys17563 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "keys", "()Ljava/util/Enumeration;");
			global::java.security.Provider._keySet17564 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "keySet", "()Ljava/util/Set;");
			global::java.security.Provider._getService17565 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getService", "(Ljava/lang/String;Ljava/lang/String;)Ljava/security/Provider$Service;");
			global::java.security.Provider._getServices17566 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getServices", "()Ljava/util/Set;");
			global::java.security.Provider._getVersion17567 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getVersion", "()D");
			global::java.security.Provider._getInfo17568 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "getInfo", "()Ljava/lang/String;");
			global::java.security.Provider._putService17569 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "putService", "(Ljava/security/Provider$Service;)V");
			global::java.security.Provider._removeService17570 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "removeService", "(Ljava/security/Provider$Service;)V");
			global::java.security.Provider._Provider17571 = @__env.GetMethodIDNoThrow(global::java.security.Provider.staticClass, "<init>", "(Ljava/lang/String;DLjava/lang/String;)V");
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
