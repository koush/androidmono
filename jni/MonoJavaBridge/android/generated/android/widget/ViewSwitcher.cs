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
			internal static global::MonoJavaBridge.MethodId _makeView18280;
			global::android.view.View android.widget.ViewSwitcher.ViewFactory.makeView()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewSwitcher.ViewFactory_._makeView18280)) as android.view.View;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewSwitcher.ViewFactory_.staticClass, global::android.widget.ViewSwitcher.ViewFactory_._makeView18280)) as android.view.View;
			}
			static ViewFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ViewSwitcher.ViewFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewSwitcher$ViewFactory"));
				global::android.widget.ViewSwitcher.ViewFactory_._makeView18280 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.ViewFactory_.staticClass, "makeView", "()Landroid/view/View;");
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
			internal static global::MonoJavaBridge.MethodId _ViewFactoryDelegateWrapper18281;
			public ViewFactoryDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewSwitcher.ViewFactoryDelegateWrapper.staticClass, global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper._ViewFactoryDelegateWrapper18281);
				Init(@__env, handle);
			}
			static ViewFactoryDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewSwitcher_ViewFactoryDelegateWrapper"));
				global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper._ViewFactoryDelegateWrapper18281 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.ViewFactoryDelegateWrapper.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _reset18282;
		public virtual void reset()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher._reset18282);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._reset18282);
		}
		internal static global::MonoJavaBridge.MethodId _addView18283;
		public override void addView(android.view.View arg0, int arg1, android.view.ViewGroup.LayoutParams arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher._addView18283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._addView18283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new global::android.widget.ViewSwitcher.ViewFactory Factory
		{
			set
			{
				setFactory(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setFactory18284;
		public virtual void setFactory(android.widget.ViewSwitcher.ViewFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher._setFactory18284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._setFactory18284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getNextView18285;
		public virtual global::android.view.View getNextView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.widget.ViewSwitcher._getNextView18285)) as android.view.View;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._getNextView18285)) as android.view.View;
		}
		internal static global::MonoJavaBridge.MethodId _ViewSwitcher18286;
		public ViewSwitcher(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._ViewSwitcher18286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ViewSwitcher18287;
		public ViewSwitcher(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.widget.ViewSwitcher.staticClass, global::android.widget.ViewSwitcher._ViewSwitcher18287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ViewSwitcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.widget.ViewSwitcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/widget/ViewSwitcher"));
			global::android.widget.ViewSwitcher._reset18282 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "reset", "()V");
			global::android.widget.ViewSwitcher._addView18283 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "addView", "(Landroid/view/View;ILandroid/view/ViewGroup$LayoutParams;)V");
			global::android.widget.ViewSwitcher._setFactory18284 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "setFactory", "(Landroid/widget/ViewSwitcher$ViewFactory;)V");
			global::android.widget.ViewSwitcher._getNextView18285 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "getNextView", "()Landroid/view/View;");
			global::android.widget.ViewSwitcher._ViewSwitcher18286 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::android.widget.ViewSwitcher._ViewSwitcher18287 = @__env.GetMethodIDNoThrow(global::android.widget.ViewSwitcher.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
