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
		internal static global::MonoJavaBridge.MethodId _inflate5888;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._inflate5888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._inflate5888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _draw5889;
		public override void draw(android.graphics.Canvas arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._draw5889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._draw5889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int ChangingConfigurations
		{
			get
			{
				return getChangingConfigurations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getChangingConfigurations5890;
		public override int getChangingConfigurations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._getChangingConfigurations5890);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._getChangingConfigurations5890);
		}
		internal static global::MonoJavaBridge.MethodId _setAlpha5891;
		public override void setAlpha(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._setAlpha5891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._setAlpha5891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setColorFilter5892;
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._setColorFilter5892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._setColorFilter5892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Opacity
		{
			get
			{
				return getOpacity();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getOpacity5893;
		public override int getOpacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._getOpacity5893);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._getOpacity5893);
		}
		public new global::android.graphics.drawable.Drawable.ConstantState ConstantState
		{
			get
			{
				return getConstantState();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getConstantState5894;
		public override global::android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._getConstantState5894)) as android.graphics.drawable.Drawable.ConstantState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._getConstantState5894)) as android.graphics.drawable.Drawable.ConstantState;
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
		internal static global::MonoJavaBridge.MethodId _getAlpha5895;
		public virtual int getAlpha() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable._getAlpha5895);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._getAlpha5895);
		}
		internal static global::MonoJavaBridge.MethodId _ColorDrawable5896;
		public ColorDrawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._ColorDrawable5896);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ColorDrawable5897;
		public ColorDrawable(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.ColorDrawable.staticClass, global::android.graphics.drawable.ColorDrawable._ColorDrawable5897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.ColorDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/ColorDrawable"));
			global::android.graphics.drawable.ColorDrawable._inflate5888 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.ColorDrawable._draw5889 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V");
			global::android.graphics.drawable.ColorDrawable._getChangingConfigurations5890 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "getChangingConfigurations", "()I");
			global::android.graphics.drawable.ColorDrawable._setAlpha5891 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "setAlpha", "(I)V");
			global::android.graphics.drawable.ColorDrawable._setColorFilter5892 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V");
			global::android.graphics.drawable.ColorDrawable._getOpacity5893 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "getOpacity", "()I");
			global::android.graphics.drawable.ColorDrawable._getConstantState5894 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;");
			global::android.graphics.drawable.ColorDrawable._getAlpha5895 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "getAlpha", "()I");
			global::android.graphics.drawable.ColorDrawable._ColorDrawable5896 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "<init>", "()V");
			global::android.graphics.drawable.ColorDrawable._ColorDrawable5897 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.ColorDrawable.staticClass, "<init>", "(I)V");
		}
	}
}
