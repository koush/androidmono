namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.LayoutInflater_))]
	public abstract partial class LayoutInflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LayoutInflater()
		{
			InitJNI();
		}
		protected LayoutInflater(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.LayoutInflater.Factory_))]
		public partial interface Factory  : global::MonoJavaBridge.IJavaObject 
		{
			global::android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.LayoutInflater.Factory))]
		internal sealed partial class Factory_ : java.lang.Object, Factory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Factory_()
			{
				InitJNI();
			}
			internal Factory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onCreateView14291;
			global::android.view.View android.view.LayoutInflater.Factory.onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.Factory_._onCreateView14291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.Factory_.staticClass, global::android.view.LayoutInflater.Factory_._onCreateView14291, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.LayoutInflater.Factory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater$Factory"));
				global::android.view.LayoutInflater.Factory_._onCreateView14291 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.Factory_.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;");
			}
		}

		public delegate android.view.View FactoryDelegate(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2);

		internal partial class FactoryDelegateWrapper : java.lang.Object, Factory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FactoryDelegateWrapper()
			{
				InitJNI();
			}
			protected FactoryDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _FactoryDelegateWrapper14292;
			public FactoryDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.LayoutInflater.FactoryDelegateWrapper.staticClass, global::android.view.LayoutInflater.FactoryDelegateWrapper._FactoryDelegateWrapper14292);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.LayoutInflater.FactoryDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater_FactoryDelegateWrapper"));
				global::android.view.LayoutInflater.FactoryDelegateWrapper._FactoryDelegateWrapper14292 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.FactoryDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class FactoryDelegateWrapper
		{
			private FactoryDelegate myDelegate;
			public android.view.View onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2)
			{
				return myDelegate(arg0, arg1, arg2);
			}
			public static implicit operator FactoryDelegateWrapper(FactoryDelegate d)
			{
				global::android.view.LayoutInflater.FactoryDelegateWrapper ret = new global::android.view.LayoutInflater.FactoryDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.LayoutInflater.Filter_))]
		public partial interface Filter  : global::MonoJavaBridge.IJavaObject 
		{
			bool onLoadClass(java.lang.Class arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.LayoutInflater.Filter))]
		internal sealed partial class Filter_ : java.lang.Object, Filter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Filter_()
			{
				InitJNI();
			}
			internal Filter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onLoadClass14293;
			bool android.view.LayoutInflater.Filter.onLoadClass(java.lang.Class arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallBooleanMethod(this.JvmHandle, global::android.view.LayoutInflater.Filter_._onLoadClass14293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.view.LayoutInflater.Filter_.staticClass, global::android.view.LayoutInflater.Filter_._onLoadClass14293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.LayoutInflater.Filter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater$Filter"));
				global::android.view.LayoutInflater.Filter_._onLoadClass14293 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.Filter_.staticClass, "onLoadClass", "(Ljava/lang/Class;)Z");
			}
		}

		public delegate bool FilterDelegate(java.lang.Class arg0);

		internal partial class FilterDelegateWrapper : java.lang.Object, Filter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static FilterDelegateWrapper()
			{
				InitJNI();
			}
			protected FilterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _FilterDelegateWrapper14294;
			public FilterDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.LayoutInflater.FilterDelegateWrapper.staticClass, global::android.view.LayoutInflater.FilterDelegateWrapper._FilterDelegateWrapper14294);
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.LayoutInflater.FilterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater_FilterDelegateWrapper"));
				global::android.view.LayoutInflater.FilterDelegateWrapper._FilterDelegateWrapper14294 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.FilterDelegateWrapper.staticClass, "<init>", "()V");
			}
		}
		internal partial class FilterDelegateWrapper
		{
			private FilterDelegate myDelegate;
			public bool onLoadClass(java.lang.Class arg0)
			{
				return myDelegate(arg0);
			}
			public static implicit operator FilterDelegateWrapper(FilterDelegate d)
			{
				global::android.view.LayoutInflater.FilterDelegateWrapper ret = new global::android.view.LayoutInflater.FilterDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		internal static global::MonoJavaBridge.MethodId _from14295;
		public static global::android.view.LayoutInflater from(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._from14295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.LayoutInflater;
		}
		internal static global::MonoJavaBridge.MethodId _getFactory14296;
		public virtual global::android.view.LayoutInflater.Factory getFactory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.LayoutInflater.Factory>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._getFactory14296)) as android.view.LayoutInflater.Factory;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.LayoutInflater.Factory>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._getFactory14296)) as android.view.LayoutInflater.Factory;
		}
		internal static global::MonoJavaBridge.MethodId _getContext14297;
		public virtual global::android.content.Context getContext()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._getContext14297)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._getContext14297)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _inflate14298;
		public virtual global::android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._inflate14298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate14298, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _inflate14299;
		public virtual global::android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._inflate14299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate14299, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _inflate14300;
		public virtual global::android.view.View inflate(int arg0, android.view.ViewGroup arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._inflate14300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate14300, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _inflate14301;
		public virtual global::android.view.View inflate(int arg0, android.view.ViewGroup arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._inflate14301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._inflate14301, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _onCreateView14302;
		protected virtual global::android.view.View onCreateView(java.lang.String arg0, android.util.AttributeSet arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._onCreateView14302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._onCreateView14302, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _cloneInContext14303;
		public abstract global::android.view.LayoutInflater cloneInContext(android.content.Context arg0);
		internal static global::MonoJavaBridge.MethodId _setFactory14304;
		public virtual void setFactory(android.view.LayoutInflater.Factory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.LayoutInflater._setFactory14304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._setFactory14304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setFactory(global::android.view.LayoutInflater.FactoryDelegate arg0)
		{
			setFactory((global::android.view.LayoutInflater.FactoryDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _getFilter14305;
		public virtual global::android.view.LayoutInflater.Filter getFilter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.LayoutInflater.Filter>(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._getFilter14305)) as android.view.LayoutInflater.Filter;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.view.LayoutInflater.Filter>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._getFilter14305)) as android.view.LayoutInflater.Filter;
		}
		internal static global::MonoJavaBridge.MethodId _setFilter14306;
		public virtual void setFilter(android.view.LayoutInflater.Filter arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.view.LayoutInflater._setFilter14306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._setFilter14306, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setFilter(global::android.view.LayoutInflater.FilterDelegate arg0)
		{
			setFilter((global::android.view.LayoutInflater.FilterDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _createView14307;
		public virtual global::android.view.View createView(java.lang.String arg0, java.lang.String arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater._createView14307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._createView14307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _LayoutInflater14308;
		protected LayoutInflater(android.view.LayoutInflater arg0, android.content.Context arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._LayoutInflater14308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _LayoutInflater14309;
		protected LayoutInflater(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._LayoutInflater14309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.LayoutInflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater"));
			global::android.view.LayoutInflater._from14295 = @__env.GetStaticMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "from", "(Landroid/content/Context;)Landroid/view/LayoutInflater;");
			global::android.view.LayoutInflater._getFactory14296 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "getFactory", "()Landroid/view/LayoutInflater$Factory;");
			global::android.view.LayoutInflater._getContext14297 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.view.LayoutInflater._inflate14298 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;)Landroid/view/View;");
			global::android.view.LayoutInflater._inflate14299 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;Z)Landroid/view/View;");
			global::android.view.LayoutInflater._inflate14300 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;Z)Landroid/view/View;");
			global::android.view.LayoutInflater._inflate14301 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;)Landroid/view/View;");
			global::android.view.LayoutInflater._onCreateView14302 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;");
			global::android.view.LayoutInflater._cloneInContext14303 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "cloneInContext", "(Landroid/content/Context;)Landroid/view/LayoutInflater;");
			global::android.view.LayoutInflater._setFactory14304 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "setFactory", "(Landroid/view/LayoutInflater$Factory;)V");
			global::android.view.LayoutInflater._getFilter14305 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "getFilter", "()Landroid/view/LayoutInflater$Filter;");
			global::android.view.LayoutInflater._setFilter14306 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "setFilter", "(Landroid/view/LayoutInflater$Filter;)V");
			global::android.view.LayoutInflater._createView14307 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "createView", "(Ljava/lang/String;Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;");
			global::android.view.LayoutInflater._LayoutInflater14308 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/view/LayoutInflater;Landroid/content/Context;)V");
			global::android.view.LayoutInflater._LayoutInflater14309 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/content/Context;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.LayoutInflater))]
	internal sealed partial class LayoutInflater_ : android.view.LayoutInflater
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LayoutInflater_()
		{
			InitJNI();
		}
		internal LayoutInflater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _cloneInContext14310;
		public override global::android.view.LayoutInflater cloneInContext(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.view.LayoutInflater_._cloneInContext14310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.LayoutInflater;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.view.LayoutInflater_.staticClass, global::android.view.LayoutInflater_._cloneInContext14310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.LayoutInflater;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.LayoutInflater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater"));
			global::android.view.LayoutInflater_._cloneInContext14310 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater_.staticClass, "cloneInContext", "(Landroid/content/Context;)Landroid/view/LayoutInflater;");
		}
	}
}
