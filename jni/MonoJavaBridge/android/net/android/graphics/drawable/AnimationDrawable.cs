namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AnimationDrawable : android.graphics.drawable.DrawableContainer, java.lang.Runnable, Animatable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AnimationDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.AnimationDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _run3232; 
		public virtual void run() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				@__env.CallVoidMethod(this, _run3232); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _run3232); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start3233; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				@__env.CallVoidMethod(this, _start3233); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _start3233); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop3234; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				@__env.CallVoidMethod(this, _stop3234); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _stop3234); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3235; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				@__env.CallVoidMethod(this, _inflate3235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _inflate3235, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleSelf3236; 
		public override void unscheduleSelf(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				@__env.CallVoidMethod(this, _unscheduleSelf3236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _unscheduleSelf3236, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3237; 
		public override bool setVisible(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				return @__env.CallBooleanMethod(this, _setVisible3237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _setVisible3237, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3238; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3238)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.AnimationDrawable.staticClass, _mutate3238)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDuration3239; 
		public virtual int getDuration(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				return @__env.CallIntMethod(this, _getDuration3239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _getDuration3239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRunning3240; 
		public virtual bool isRunning() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				return @__env.CallBooleanMethod(this, _isRunning3240); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _isRunning3240); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNumberOfFrames3241; 
		public virtual int getNumberOfFrames() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				return @__env.CallIntMethod(this, _getNumberOfFrames3241); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _getNumberOfFrames3241); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFrame3242; 
		public virtual android.graphics.drawable.Drawable getFrame(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getFrame3242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.AnimationDrawable.staticClass, _getFrame3242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isOneShot3243; 
		public virtual bool isOneShot() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				return @__env.CallBooleanMethod(this, _isOneShot3243); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _isOneShot3243); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOneShot3244; 
		public virtual void setOneShot(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				@__env.CallVoidMethod(this, _setOneShot3244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _setOneShot3244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addFrame3245; 
		public virtual void addFrame(android.graphics.drawable.Drawable arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.AnimationDrawable)) 
				@__env.CallVoidMethod(this, _addFrame3245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.AnimationDrawable.staticClass, _addFrame3245, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AnimationDrawable3246; 
		public AnimationDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.AnimationDrawable.staticClass, _AnimationDrawable3246, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.AnimationDrawable.staticClass = @__class; 
			global::android.graphics.drawable.AnimationDrawable._run3232 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "run", "()V"); 
			global::android.graphics.drawable.AnimationDrawable._start3233 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "start", "()V"); 
			global::android.graphics.drawable.AnimationDrawable._stop3234 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "stop", "()V"); 
			global::android.graphics.drawable.AnimationDrawable._inflate3235 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.AnimationDrawable._unscheduleSelf3236 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V"); 
			global::android.graphics.drawable.AnimationDrawable._setVisible3237 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "setVisible", "(ZZ)Z"); 
			global::android.graphics.drawable.AnimationDrawable._mutate3238 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.AnimationDrawable._getDuration3239 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "getDuration", "(I)I"); 
			global::android.graphics.drawable.AnimationDrawable._isRunning3240 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "isRunning", "()Z"); 
			global::android.graphics.drawable.AnimationDrawable._getNumberOfFrames3241 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "getNumberOfFrames", "()I"); 
			global::android.graphics.drawable.AnimationDrawable._getFrame3242 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "getFrame", "(I)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.AnimationDrawable._isOneShot3243 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "isOneShot", "()Z"); 
			global::android.graphics.drawable.AnimationDrawable._setOneShot3244 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "setOneShot", "(Z)V"); 
			global::android.graphics.drawable.AnimationDrawable._addFrame3245 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "addFrame", "(Landroid/graphics/drawable/Drawable;I)V"); 
			global::android.graphics.drawable.AnimationDrawable._AnimationDrawable3246 = @__env.GetMethodID(global::android.graphics.drawable.AnimationDrawable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
