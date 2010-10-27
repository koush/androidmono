namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StateListDrawable : android.graphics.drawable.DrawableContainer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StateListDrawable()
		{
			InitJNI();
		}
		protected StateListDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate6227;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.StateListDrawable._inflate6227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.StateListDrawable.staticClass, global::android.graphics.drawable.StateListDrawable._inflate6227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isStateful6228;
		public override bool isStateful()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.StateListDrawable._isStateful6228);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.StateListDrawable.staticClass, global::android.graphics.drawable.StateListDrawable._isStateful6228);
		}
		internal static global::MonoJavaBridge.MethodId _onStateChange6229;
		protected override bool onStateChange(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.StateListDrawable._onStateChange6229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.StateListDrawable.staticClass, global::android.graphics.drawable.StateListDrawable._onStateChange6229, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _mutate6230;
		public override global::android.graphics.drawable.Drawable mutate()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.StateListDrawable._mutate6230)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.StateListDrawable.staticClass, global::android.graphics.drawable.StateListDrawable._mutate6230)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _addState6231;
		public virtual void addState(int[] arg0, android.graphics.drawable.Drawable arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.StateListDrawable._addState6231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.StateListDrawable.staticClass, global::android.graphics.drawable.StateListDrawable._addState6231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _StateListDrawable6232;
		public StateListDrawable() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.StateListDrawable.staticClass, global::android.graphics.drawable.StateListDrawable._StateListDrawable6232);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.StateListDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/StateListDrawable"));
			global::android.graphics.drawable.StateListDrawable._inflate6227 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.StateListDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.StateListDrawable._isStateful6228 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.StateListDrawable.staticClass, "isStateful", "()Z");
			global::android.graphics.drawable.StateListDrawable._onStateChange6229 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.StateListDrawable.staticClass, "onStateChange", "([I)Z");
			global::android.graphics.drawable.StateListDrawable._mutate6230 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.StateListDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.StateListDrawable._addState6231 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.StateListDrawable.staticClass, "addState", "([ILandroid/graphics/drawable/Drawable;)V");
			global::android.graphics.drawable.StateListDrawable._StateListDrawable6232 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.StateListDrawable.staticClass, "<init>", "()V");
		}
	}
}
