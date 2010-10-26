namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ColorDrawable : android.graphics.drawable.Drawable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ColorDrawable()
		{
			InitJNI();
		}
		protected ColorDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _inflate5907;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._inflate5907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._inflate5907, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw5908;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._draw5908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._draw5908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5909;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._getChangingConfigurations5909);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._getChangingConfigurations5909);
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5910;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._setAlpha5910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._setAlpha5910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter5911;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._setColorFilter5911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._setColorFilter5911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity5912;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._getOpacity5912);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._getOpacity5912);
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState5913;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._getConstantState5913)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._getConstantState5913)) as android.graphics.drawable.Drawable.ConstantState;
		}
		public new int Alpha
		{
			get
			{
				return getAlpha();
			}
			set
			{
				setAlpha(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getAlpha5914;
		public virtual int getAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._getAlpha5914);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._getAlpha5914);
		}
		internal static global::MonoJavaBridge.MethodId _ColorDrawable5915;
		public ColorDrawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._ColorDrawable5915);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ColorDrawable5916;
		public ColorDrawable(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._ColorDrawable5916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.ColorDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ColorDrawable"));
			global::android.graphics.drawable.ColorDrawable._inflate5907 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.ColorDrawable._draw5908 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.ColorDrawable._getChangingConfigurations5909 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.ColorDrawable._setAlpha5910 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.ColorDrawable._setColorFilter5911 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.ColorDrawable._getOpacity5912 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.ColorDrawable._getConstantState5913 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.ColorDrawable._getAlpha5914 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "getAlpha", "()I");
			global::android.graphics.drawable.ColorDrawable._ColorDrawable5915 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "<init>", "()V");
			global::android.graphics.drawable.ColorDrawable._ColorDrawable5916 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "<init>", "(I)V");
		}
	}
}
