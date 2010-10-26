namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LevelListDrawable : android.graphics.drawable.DrawableContainer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LevelListDrawable()
		{
			InitJNI();
		}
		protected LevelListDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate6111;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LevelListDrawable._inflate6111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LevelListDrawable.staticClass, global::android.graphics.drawable.LevelListDrawable._inflate6111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onLevelChange6112;
		protected override bool onLevelChange(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LevelListDrawable._onLevelChange6112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.LevelListDrawable.staticClass, global::android.graphics.drawable.LevelListDrawable._onLevelChange6112, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate6113;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.LevelListDrawable._mutate6113)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.LevelListDrawable.staticClass, global::android.graphics.drawable.LevelListDrawable._mutate6113)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _addLevel6114;
		public virtual void addLevel(int arg0, int arg1, android.graphics.drawable.Drawable arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.LevelListDrawable._addLevel6114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.LevelListDrawable.staticClass, global::android.graphics.drawable.LevelListDrawable._addLevel6114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _LevelListDrawable6115;
		public LevelListDrawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.LevelListDrawable.staticClass, global::android.graphics.drawable.LevelListDrawable._LevelListDrawable6115);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.LevelListDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/LevelListDrawable"));
			global::android.graphics.drawable.LevelListDrawable._inflate6111 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LevelListDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.LevelListDrawable._onLevelChange6112 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LevelListDrawable.staticClass, "onLevelChange", "(I)Z");
			global::android.graphics.drawable.LevelListDrawable._mutate6113 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LevelListDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.LevelListDrawable._addLevel6114 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LevelListDrawable.staticClass, "addLevel", "(IILandroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.LevelListDrawable._LevelListDrawable6115 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.LevelListDrawable.staticClass, "<init>", "()V");
		}
	}
}
