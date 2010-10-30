namespace android.view
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.view.LayoutInflater_))]
	public abstract partial class LayoutInflater : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
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
			internal Factory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			global::android.view.View android.view.LayoutInflater.Factory.onCreateView(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.LayoutInflater.Factory_.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/content/Context;Landroid/util/AttributeSet;)Landroid/view/View;", ref global::android.view.LayoutInflater.Factory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
			}
			static Factory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.LayoutInflater.Factory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater$Factory"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate android.view.View FactoryDelegate(java.lang.String arg0, android.content.Context arg1, android.util.AttributeSet arg2);

		internal partial class FactoryDelegateWrapper : java.lang.Object, Factory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected FactoryDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public FactoryDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.LayoutInflater.FactoryDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.LayoutInflater.FactoryDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.FactoryDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.LayoutInflater.FactoryDelegateWrapper.staticClass, global::android.view.LayoutInflater.FactoryDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static FactoryDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.LayoutInflater.FactoryDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater_FactoryDelegateWrapper"));
			}
			internal static void InitJNI()
			{
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
			internal Filter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			bool android.view.LayoutInflater.Filter.onLoadClass(java.lang.Class arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.LayoutInflater.Filter_.staticClass, "onLoadClass", "(Ljava/lang/Class;)Z", ref global::android.view.LayoutInflater.Filter_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static Filter_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.LayoutInflater.Filter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater$Filter"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate bool FilterDelegate(java.lang.Class arg0);

		internal partial class FilterDelegateWrapper : java.lang.Object, Filter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected FilterDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public FilterDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.LayoutInflater.FilterDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.LayoutInflater.FilterDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.FilterDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.LayoutInflater.FilterDelegateWrapper.staticClass, global::android.view.LayoutInflater.FilterDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static FilterDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.LayoutInflater.FilterDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater_FilterDelegateWrapper"));
			}
			internal static void InitJNI()
			{
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
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.view.LayoutInflater from(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.LayoutInflater._m0.native == global::System.IntPtr.Zero)
				global::android.view.LayoutInflater._m0 = @__env.GetStaticMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "from", "(Landroid/content/Context;)Landroid/view/LayoutInflater;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.view.LayoutInflater;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.view.LayoutInflater.Factory getFactory()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.LayoutInflater.Factory>(this, global::android.view.LayoutInflater.staticClass, "getFactory", "()Landroid/view/LayoutInflater$Factory;", ref global::android.view.LayoutInflater._m1) as android.view.LayoutInflater.Factory;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.content.Context getContext()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.LayoutInflater.staticClass, "getContext", "()Landroid/content/Context;", ref global::android.view.LayoutInflater._m2) as android.content.Context;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;)Landroid/view/View;", ref global::android.view.LayoutInflater._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual global::android.view.View inflate(org.xmlpull.v1.XmlPullParser arg0, android.view.ViewGroup arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.LayoutInflater.staticClass, "inflate", "(Lorg/xmlpull/v1/XmlPullParser;Landroid/view/ViewGroup;Z)Landroid/view/View;", ref global::android.view.LayoutInflater._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.view.View inflate(int arg0, android.view.ViewGroup arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;Z)Landroid/view/View;", ref global::android.view.LayoutInflater._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::android.view.View inflate(int arg0, android.view.ViewGroup arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.LayoutInflater.staticClass, "inflate", "(ILandroid/view/ViewGroup;)Landroid/view/View;", ref global::android.view.LayoutInflater._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual global::android.view.View onCreateView(java.lang.String arg0, android.util.AttributeSet arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.LayoutInflater.staticClass, "onCreateView", "(Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;", ref global::android.view.LayoutInflater._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public abstract global::android.view.LayoutInflater cloneInContext(android.content.Context arg0);
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setFactory(android.view.LayoutInflater.Factory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.LayoutInflater.staticClass, "setFactory", "(Landroid/view/LayoutInflater$Factory;)V", ref global::android.view.LayoutInflater._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setFactory(global::android.view.LayoutInflater.FactoryDelegate arg0)
		{
			setFactory((global::android.view.LayoutInflater.FactoryDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual global::android.view.LayoutInflater.Filter getFilter()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.LayoutInflater.Filter>(this, global::android.view.LayoutInflater.staticClass, "getFilter", "()Landroid/view/LayoutInflater$Filter;", ref global::android.view.LayoutInflater._m10) as android.view.LayoutInflater.Filter;
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setFilter(android.view.LayoutInflater.Filter arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.LayoutInflater.staticClass, "setFilter", "(Landroid/view/LayoutInflater$Filter;)V", ref global::android.view.LayoutInflater._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setFilter(global::android.view.LayoutInflater.FilterDelegate arg0)
		{
			setFilter((global::android.view.LayoutInflater.FilterDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual global::android.view.View createView(java.lang.String arg0, java.lang.String arg1, android.util.AttributeSet arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.LayoutInflater.staticClass, "createView", "(Ljava/lang/String;Ljava/lang/String;Landroid/util/AttributeSet;)Landroid/view/View;", ref global::android.view.LayoutInflater._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2)) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m13;
		protected LayoutInflater(android.view.LayoutInflater arg0, android.content.Context arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.LayoutInflater._m13.native == global::System.IntPtr.Zero)
				global::android.view.LayoutInflater._m13 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/view/LayoutInflater;Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		protected LayoutInflater(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.LayoutInflater._m14.native == global::System.IntPtr.Zero)
				global::android.view.LayoutInflater._m14 = @__env.GetMethodIDNoThrow(global::android.view.LayoutInflater.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.LayoutInflater.staticClass, global::android.view.LayoutInflater._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static LayoutInflater()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.LayoutInflater.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.LayoutInflater))]
	internal sealed partial class LayoutInflater_ : android.view.LayoutInflater
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal LayoutInflater_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::android.view.LayoutInflater cloneInContext(android.content.Context arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.LayoutInflater_.staticClass, "cloneInContext", "(Landroid/content/Context;)Landroid/view/LayoutInflater;", ref global::android.view.LayoutInflater_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.view.LayoutInflater;
		}
		static LayoutInflater_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.LayoutInflater_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/LayoutInflater"));
		}
		internal static void InitJNI()
		{
		}
	}
}
