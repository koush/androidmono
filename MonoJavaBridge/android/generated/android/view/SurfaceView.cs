namespace android.view
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SurfaceView : android.view.View
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SurfaceView(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void draw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceView.staticClass, "draw", "(Landroid/graphics/Canvas;)V", ref global::android.view.SurfaceView._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onAttachedToWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceView.staticClass, "onAttachedToWindow", "()V", ref global::android.view.SurfaceView._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onDetachedFromWindow()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceView.staticClass, "onDetachedFromWindow", "()V", ref global::android.view.SurfaceView._m2);
		}
		public new int Visibility
		{
			set
			{
				setVisibility(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override void setVisibility(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceView.staticClass, "setVisibility", "(I)V", ref global::android.view.SurfaceView._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		protected override void onWindowVisibilityChanged(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceView.staticClass, "onWindowVisibilityChanged", "(I)V", ref global::android.view.SurfaceView._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected override void onSizeChanged(int arg0, int arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceView.staticClass, "onSizeChanged", "(IIII)V", ref global::android.view.SurfaceView._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected override void dispatchDraw(android.graphics.Canvas arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceView.staticClass, "dispatchDraw", "(Landroid/graphics/Canvas;)V", ref global::android.view.SurfaceView._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected override void onMeasure(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceView.staticClass, "onMeasure", "(II)V", ref global::android.view.SurfaceView._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool gatherTransparentRegion(android.graphics.Region arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.view.SurfaceView.staticClass, "gatherTransparentRegion", "(Landroid/graphics/Region;)Z", ref global::android.view.SurfaceView._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::android.view.SurfaceHolder Holder
		{
			get
			{
				return getHolder();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.view.SurfaceHolder getHolder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.view.SurfaceHolder>(this, global::android.view.SurfaceView.staticClass, "getHolder", "()Landroid/view/SurfaceHolder;", ref global::android.view.SurfaceView._m9) as android.view.SurfaceHolder;
		}
		public new bool ZOrderMediaOverlay
		{
			set
			{
				setZOrderMediaOverlay(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void setZOrderMediaOverlay(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceView.staticClass, "setZOrderMediaOverlay", "(Z)V", ref global::android.view.SurfaceView._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new bool ZOrderOnTop
		{
			set
			{
				setZOrderOnTop(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void setZOrderOnTop(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.view.SurfaceView.staticClass, "setZOrderOnTop", "(Z)V", ref global::android.view.SurfaceView._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public SurfaceView(android.content.Context arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.SurfaceView._m12.native == global::System.IntPtr.Zero)
				global::android.view.SurfaceView._m12 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.SurfaceView._m13.native == global::System.IntPtr.Zero)
				global::android.view.SurfaceView._m13 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public SurfaceView(android.content.Context arg0, android.util.AttributeSet arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.view.SurfaceView._m14.native == global::System.IntPtr.Zero)
				global::android.view.SurfaceView._m14 = @__env.GetMethodIDNoThrow(global::android.view.SurfaceView.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.SurfaceView.staticClass, global::android.view.SurfaceView._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static SurfaceView()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.SurfaceView.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/SurfaceView"));
		}
		internal static void InitJNI()
		{
		}
	}
}
