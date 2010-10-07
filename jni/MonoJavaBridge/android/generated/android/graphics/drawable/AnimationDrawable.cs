namespace android.graphics.drawable
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class AnimationDrawable : android.graphics.drawable.DrawableContainer, java.lang.Runnable, Animatable
	{
		internal new static global::java.lang.Class staticClass;
		static AnimationDrawable()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.graphics.drawable.AnimationDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.graphics.drawable.AnimationDrawable(@__env);
			}
		}
		protected AnimationDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _run3641;
		public virtual void run() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable._run3641);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._run3641);
		}
		internal static global::net.sf.jni4net.jni.MethodId _start3642;
		public virtual void start() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable._start3642);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._start3642);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop3643;
		public virtual void stop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable._stop3643);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._stop3643);
		}
		internal static global::net.sf.jni4net.jni.MethodId _inflate3644;
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable._inflate3644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._inflate3644, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleSelf3645;
		public override void unscheduleSelf(java.lang.Runnable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable._unscheduleSelf3645, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._unscheduleSelf3645, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3646;
		public override bool setVisible(bool arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable._setVisible3646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._setVisible3646, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _mutate3647;
		public override global::android.graphics.drawable.Drawable mutate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.AnimationDrawable._mutate3647));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._mutate3647));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDuration3648;
		public virtual int getDuration(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.AnimationDrawable._getDuration3648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._getDuration3648, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isRunning3649;
		public virtual bool isRunning() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable._isRunning3649);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._isRunning3649);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNumberOfFrames3650;
		public virtual int getNumberOfFrames() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.graphics.drawable.AnimationDrawable._getNumberOfFrames3650);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._getNumberOfFrames3650);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFrame3651;
		public virtual global::android.graphics.drawable.Drawable getFrame(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, global::android.graphics.drawable.AnimationDrawable._getFrame3651, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._getFrame3651, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOneShot3652;
		public virtual bool isOneShot() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable._isOneShot3652);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._isOneShot3652);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOneShot3653;
		public virtual void setOneShot(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable._setOneShot3653, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._setOneShot3653, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addFrame3654;
		public virtual void addFrame(android.graphics.drawable.Drawable arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.graphics.drawable.AnimationDrawable._addFrame3654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._addFrame3654, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AnimationDrawable3655;
		public AnimationDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.graphics.drawable.AnimationDrawable.staticClass, global::android.graphics.drawable.AnimationDrawable._AnimationDrawable3655, this);
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.graphics.drawable.AnimationDrawable.staticClass = @__class;
			global::android.graphics.drawable.AnimationDrawable._run3641 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "run", "()V");
			global::android.graphics.drawable.AnimationDrawable._start3642 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "start", "()V");
			global::android.graphics.drawable.AnimationDrawable._stop3643 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "stop", "()V");
			global::android.graphics.drawable.AnimationDrawable._inflate3644 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V");
			global::android.graphics.drawable.AnimationDrawable._unscheduleSelf3645 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V");
			global::android.graphics.drawable.AnimationDrawable._setVisible3646 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "setVisible", "(ZZ)Z");
			global::android.graphics.drawable.AnimationDrawable._mutate3647 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.AnimationDrawable._getDuration3648 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "getDuration", "(I)I");
			global::android.graphics.drawable.AnimationDrawable._isRunning3649 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "isRunning", "()Z");
			global::android.graphics.drawable.AnimationDrawable._getNumberOfFrames3650 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "getNumberOfFrames", "()I");
			global::android.graphics.drawable.AnimationDrawable._getFrame3651 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "getFrame", "(I)Landroid/graphics/drawable/Drawable;");
			global::android.graphics.drawable.AnimationDrawable._isOneShot3652 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "isOneShot", "()Z");
			global::android.graphics.drawable.AnimationDrawable._setOneShot3653 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "setOneShot", "(Z)V");
			global::android.graphics.drawable.AnimationDrawable._addFrame3654 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "addFrame", "(Landroid/graphics/drawable/Drawable;I)V");
			global::android.graphics.drawable.AnimationDrawable._AnimationDrawable3655 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "<init>", "()V");
		}
	}
}
