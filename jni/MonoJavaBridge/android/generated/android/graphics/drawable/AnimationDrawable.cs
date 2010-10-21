namespace android.graphics.drawable
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AnimationDrawable : android.graphics.drawable.DrawableContainer, java.lang.Runnable, Animatable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AnimationDrawable()
		{
			InitJNI();
		}
		protected AnimationDrawable(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _run5818;
		public virtual void run() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._run5818);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._run5818);
		}
		internal static global::MonoJavaBridge.MethodId _start5819;
		public virtual void start() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._start5819);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._start5819);
		}
		internal static global::MonoJavaBridge.MethodId _stop5820;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._stop5820);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._stop5820);
		}
		internal static global::MonoJavaBridge.MethodId _inflate5821;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._inflate5821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._inflate5821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _unscheduleSelf5822;
		public override void unscheduleSelf(java.lang.Runnable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._unscheduleSelf5822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._unscheduleSelf5822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVisible5823;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._setVisible5823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._setVisible5823, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _mutate5824;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._mutate5824)) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._mutate5824)) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _getDuration5825;
		public virtual int getDuration(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._getDuration5825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._getDuration5825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isRunning5826;
		public virtual bool isRunning() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._isRunning5826);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._isRunning5826);
		}
		public new int NumberOfFrames
		{
			get
			{
				return getNumberOfFrames();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNumberOfFrames5827;
		public virtual int getNumberOfFrames() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._getNumberOfFrames5827);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._getNumberOfFrames5827);
		}
		internal static global::MonoJavaBridge.MethodId _getFrame5828;
		public virtual global::android.graphics.drawable.Drawable getFrame(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._getFrame5828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._getFrame5828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
		}
		internal static global::MonoJavaBridge.MethodId _isOneShot5829;
		public virtual bool isOneShot() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._isOneShot5829);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._isOneShot5829);
		}
		internal static global::MonoJavaBridge.MethodId _setOneShot5830;
		public virtual void setOneShot(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._setOneShot5830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._setOneShot5830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addFrame5831;
		public virtual void addFrame(android.graphics.drawable.Drawable arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable._addFrame5831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._addFrame5831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AnimationDrawable5832;
		public AnimationDrawable()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._AnimationDrawable5832);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.drawable.AnimationDrawable.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/drawable/AnimationDrawable"));
			global::android.graphics.drawable.AnimationDrawable._run5818 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "run", "()V");
			global::android.graphics.drawable.AnimationDrawable._start5819 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "start", "()V");
			global::android.graphics.drawable.AnimationDrawable._stop5820 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "stop", "()V");
			global::android.graphics.drawable.AnimationDrawable._inflate5821 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.AnimationDrawable._unscheduleSelf5822 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.AnimationDrawable._setVisible5823 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.AnimationDrawable._mutate5824 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.AnimationDrawable._getDuration5825 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "getDuration", "(I)I");
			global::android.graphics.drawable.AnimationDrawable._isRunning5826 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "isRunning", "()Z");
			global::android.graphics.drawable.AnimationDrawable._getNumberOfFrames5827 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "getNumberOfFrames", "()I");
			global::android.graphics.drawable.AnimationDrawable._getFrame5828 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "getFrame", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.AnimationDrawable._isOneShot5829 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "isOneShot", "()Z");
			global::android.graphics.drawable.AnimationDrawable._setOneShot5830 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "setOneShot", "(Z)V");
			global::android.graphics.drawable.AnimationDrawable._addFrame5831 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "addFrame", "(Landroid/graphics/drawable/Drawable;I)V");
			global::android.graphics.drawable.AnimationDrawable._AnimationDrawable5832 = @__env.GetMethodIDNoThrow(global::android.graphics.drawable.AnimationDrawable.staticClass, "<init>", "()V");
		}
	}
}
