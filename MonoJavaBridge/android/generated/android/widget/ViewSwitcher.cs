namespace android.widget
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ViewSwitcher : android.widget.ViewAnimator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ViewSwitcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.widget.ViewSwitcher.ViewFactory_))]
		public partial interface ViewFactory  : global::MonoJavaBridge.IJavaObject 
		{
			global::android.view.View makeView();
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.widget.ViewSwitcher.ViewFactory))]
		internal sealed partial class ViewFactory_ : java.lang.Object, ViewFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal ViewFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			global::android.view.View android.widget.ViewSwitcher.ViewFactory.makeView()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ViewSwitcher.ViewFactory_.staticClass, "makeView", "()Landroid/view/View;", ref global::android.widget.ViewSwitcher.ViewFactory_._m0) as android.view.View;
			}
			static ViewFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ViewSwitcher.ViewFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewSwitcher$ViewFactory"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate android.view.View ViewFactoryDelegate();

		internal partial class ViewFactoryDelegateWrapper : java.lang.Object, ViewFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected ViewFactoryDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public ViewFactoryDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewSwitcher.ViewFactoryDelegateWrapper.staticClass, global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static ViewFactoryDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewSwitcher_ViewFactoryDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class ViewFactoryDelegateWrapper
		{
			private ViewFactoryDelegate myDelegate;
			public android.view.View makeView()
			{
				return myDelegate();
			}
			public static implicit operator ViewFactoryDelegateWrapper(ViewFactoryDelegate d)
			{
				global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper ret = new global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void reset()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewSwitcher.staticClass, "reset", "()V", ref global::android.widget.ViewSwitcher._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewSwitcher.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V", ref global::android.widget.ViewSwitcher._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.widget.ViewSwitcher.ViewFactory Factory
		{
			set
			{
				setFactory(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void setFactory(android.widget.ViewSwitcher.ViewFactory arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.widget.ViewSwitcher.staticClass, "setFactory", "(Landroid/widget/ViewSwitcher$ViewFactory;)V", ref global::android.widget.ViewSwitcher._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setFactory(global::android.widget.ViewSwitcher.ViewFactoryDelegate arg0)
		{
			setFactory((global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper)arg0);
		}
		public new global::android.view.View NextView
		{
			get
			{
				return getNextView();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::android.view.View getNextView()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.widget.ViewSwitcher.staticClass, "getNextView", "()Landroid/view/View;", ref global::android.widget.ViewSwitcher._m3) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public ViewSwitcher(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewSwitcher._m4.native == global::System.IntPtr.Zero)
				global::android.widget.ViewSwitcher._m4 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public ViewSwitcher(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.widget.ViewSwitcher._m5.native == global::System.IntPtr.Zero)
				global::android.widget.ViewSwitcher._m5 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ViewSwitcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewSwitcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewSwitcher"));
		}
		internal static void InitJNI()
		{
		}
	}
}
