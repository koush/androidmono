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
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void setCornerRadii(float[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PaintDrawable.staticClass, "setCornerRadii", "([F)V", ref global::android.graphics.drawable.PaintDrawable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new float CornerRadius
		{
			set
			{
				setCornerRadius(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setCornerRadius(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.PaintDrawable.staticClass, "setCornerRadius", "(F)V", ref global::android.graphics.drawable.PaintDrawable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override bool inflateTag(java.lang.String arg0, android.content.res.Resources arg1, org.xmlpull.v1.XmlPullParser arg2, android.util.AttributeSet arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.PaintDrawable.staticClass, "inflateTag", "(Ljava/lang/String;Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Z", ref global::android.graphics.drawable.PaintDrawable._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public PaintDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PaintDrawable._m3.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PaintDrawable._m3 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._m3);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public PaintDrawable(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.PaintDrawable._m4.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.PaintDrawable._m4 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.PaintDrawable.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.PaintDrawable.staticClass, global::android.graphics.drawable.PaintDrawable._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static PaintDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.PaintDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/PaintDrawable"));
		}
	}
}
