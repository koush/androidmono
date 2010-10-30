namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class PaintDrawable : android.graphics.drawable.ShapeDrawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected PaintDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new float[] CornerRadii
		{
			set
			{
				setCornerRadii(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCornerRadii6140;
		public virtual void setCornerRadii(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PaintDrawable._setCornerRadii6140.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PaintDrawable._setCornerRadii6140 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "setCornerRadii", "([F)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._setCornerRadii6140, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float CornerRadius
		{
			set
			{
				setCornerRadius(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setCornerRadius6141;
		public virtual void setCornerRadius(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PaintDrawable._setCornerRadius6141.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PaintDrawable._setCornerRadius6141 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "setCornerRadius", "(F)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._setCornerRadius6141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _inflateTag6142;
		protected override bool inflateTag(java.lang.String arg0, android.content.res.Resources arg1, org.xmlpull.v1.XmlPullParser arg2, android.util.AttributeSet arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PaintDrawable._inflateTag6142.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PaintDrawable._inflateTag6142 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._inflateTag6142, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _PaintDrawable6143;
		public PaintDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PaintDrawable._PaintDrawable6143.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PaintDrawable._PaintDrawable6143 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._PaintDrawable6143);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _PaintDrawable6144;
		public PaintDrawable(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PaintDrawable._PaintDrawable6144.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PaintDrawable._PaintDrawable6144 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._PaintDrawable6144, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PaintDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.PaintDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/PaintDrawable"));
		}
		internal static void InitJNI()
		{
		}
	}
}
