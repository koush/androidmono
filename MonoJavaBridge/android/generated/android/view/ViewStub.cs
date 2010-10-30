namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ViewStub : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ViewStub(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.view.ViewStub.OnInflateListener_))]
		public partial interface OnInflateListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onInflate(android.view.ViewStub arg0, android.view.View arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.view.ViewStub.OnInflateListener))]
		internal sealed partial class OnInflateListener_ : java.lang.Object, OnInflateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnInflateListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.view.ViewStub.OnInflateListener.onInflate(android.view.ViewStub arg0, android.view.View arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.OnInflateListener_.staticClass, "onInflate", "(Landroid/view/ViewStub;Landroid/view/View;)V", ref global::android.view.ViewStub.OnInflateListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnInflateListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewStub.OnInflateListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewStub$OnInflateListener"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnInflateListenerDelegate(android.view.ViewStub arg0, android.view.View arg1);

		internal partial class OnInflateListenerDelegateWrapper : java.lang.Object, OnInflateListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnInflateListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnInflateListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.view.ViewStub.OnInflateListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.view.ViewStub.OnInflateListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.OnInflateListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.OnInflateListenerDelegateWrapper.staticClass, global::android.view.ViewStub.OnInflateListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnInflateListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.view.ViewStub.OnInflateListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewStub_OnInflateListenerDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class OnInflateListenerDelegateWrapper
		{
			private OnInflateListenerDelegate myDelegate;
			public void onInflate(android.view.ViewStub arg0, android.view.View arg1)
			{
				myDelegate(arg0, arg1);
			}
			public static implicit operator OnInflateListenerDelegateWrapper(OnInflateListenerDelegate d)
			{
				global::android.view.ViewStub.OnInflateListenerDelegateWrapper ret = new global::android.view.ViewStub.OnInflateListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::android.view.View inflate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.view.ViewStub.staticClass, "inflate", "()Landroid/view/View;", ref global::android.view.ViewStub._m0) as android.view.View;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.view.ViewStub._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Visibility
		{
			set
			{
				setVisibility(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override void setVisibility(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.staticClass, "setVisibility", "(I)V", ref global::android.view.ViewStub._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public void setLayoutResource(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.staticClass, "setLayoutResource", "(I)V", ref global::android.view.ViewStub._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int LayoutResource
		{
			get
			{
				return getLayoutResource();
			}
			set
			{
				setLayoutResource(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int getLayoutResource()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewStub.staticClass, "getLayoutResource", "()I", ref global::android.view.ViewStub._m4);
		}
		public new int InflatedId
		{
			get
			{
				return getInflatedId();
			}
			set
			{
				setInflatedId(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int getInflatedId()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.view.ViewStub.staticClass, "getInflatedId", "()I", ref global::android.view.ViewStub._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void setInflatedId(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.staticClass, "setInflatedId", "(I)V", ref global::android.view.ViewStub._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public void setOnInflateListener(android.view.ViewStub.OnInflateListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.ViewStub.staticClass, "setOnInflateListener", "(Landroid/view/ViewStub$OnInflateListener;)V", ref global::android.view.ViewStub._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void setOnInflateListener(global::android.view.ViewStub.OnInflateListenerDelegate arg0)
		{
			setOnInflateListener((global::android.view.ViewStub.OnInflateListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public ViewStub(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewStub._m8.native == global::System.IntPtr.Zero)
				global::android.view.ViewStub._m8 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public ViewStub(android.content.Context arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewStub._m9.native == global::System.IntPtr.Zero)
				global::android.view.ViewStub._m9 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewStub._m10.native == global::System.IntPtr.Zero)
				global::android.view.ViewStub._m10 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public ViewStub(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.ViewStub._m11.native == global::System.IntPtr.Zero)
				global::android.view.ViewStub._m11 = @__env.GetMethodIDNoThrow(global::android.view.ViewStub.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.ViewStub.staticClass, global::android.view.ViewStub._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ViewStub()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.ViewStub.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/ViewStub"));
		}
		internal static void InitJNI()
		{
		}
	}
}
