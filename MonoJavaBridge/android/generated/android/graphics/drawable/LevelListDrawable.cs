namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LevelListDrawable : android.graphics.drawable.DrawableContainer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected LevelListDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.LevelListDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V", ref global::android.graphics.drawable.LevelListDrawable._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override bool onLevelChange(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.graphics.drawable.LevelListDrawable.staticClass, "onLevelChange", "(I)Z", ref global::android.graphics.drawable.LevelListDrawable._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.graphics.drawable.LevelListDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;", ref global::android.graphics.drawable.LevelListDrawable._m2) as android.graphics.drawable.Drawable;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void addLevel(int arg0, int arg1, android.graphics.drawable.Drawable arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.graphics.drawable.LevelListDrawable.staticClass, "addLevel", "(IILandroid/graphics/drawable/Drawable;)V", ref global::android.graphics.drawable.LevelListDrawable._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public LevelListDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.graphics.drawable.LevelListDrawable._m4.native == global::System.IntPtr.Zero)
				global::android.graphics.drawable.LevelListDrawable._m4 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LevelListDrawable.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.LevelListDrawable.staticClass, global::android.graphics.drawable.LevelListDrawable._m4);
			Init(@__env, handle);
		}
		static LevelListDrawable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.LevelListDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/LevelListDrawable"));
		}
	}
}
