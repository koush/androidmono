namespace android.view.animation 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Animation : java.lang.Object, java.lang.Cloneable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Animation() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.Animation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Animation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface AnimationListener 
		{ 
			void onAnimationStart(android.view.animation.Animation arg0); 
			void onAnimationEnd(android.view.animation.Animation arg0); 
			void onAnimationRepeat(android.view.animation.Animation arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected class Description : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Description() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.view.animation.Animation.Description), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.view.animation.Animation.Description(@__env); 
				} 
			} 
			protected Description(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Description8208; 
			protected Description()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.view.animation.Animation.Description.staticClass, _Description8208, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _type8209; 
			public int type
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _value8210; 
			public float value
			{ 
				get 
				{ 
					return default(float); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.view.animation.Animation.Description.staticClass = @__class; 
				global::android.view.animation.Animation.Description._Description8208 = @__env.GetMethodID(global::android.view.animation.Animation.Description.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clone8211; 
		protected virtual android.view.animation.Animation clone() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallObjectMethodPtr(this, _clone8211)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.view.animation.Animation>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.animation.Animation.staticClass, _clone8211)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _start8212; 
		public virtual void start() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _start8212); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _start8212); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _reset8213; 
		public virtual void reset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _reset8213); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _reset8213); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _initialize8214; 
		public virtual void initialize(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _initialize8214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _initialize8214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _resolveSize8215; 
		protected virtual float resolveSize(int arg0, float arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallFloatMethod(this, _resolveSize8215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.view.animation.Animation.staticClass, _resolveSize8215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRepeatCount8216; 
		public virtual int getRepeatCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallIntMethod(this, _getRepeatCount8216); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.animation.Animation.staticClass, _getRepeatCount8216); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator8217; 
		public virtual void setInterpolator(android.view.animation.Interpolator arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setInterpolator8217, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setInterpolator8217, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setInterpolator8218; 
		public virtual void setInterpolator(android.content.Context arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setInterpolator8218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setInterpolator8218, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInterpolator8219; 
		public virtual android.view.animation.Interpolator getInterpolator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallObjectMethodPtr(this, _getInterpolator8219)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.view.animation.Interpolator>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.view.animation.Animation.staticClass, _getInterpolator8219)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isInitialized8220; 
		public virtual bool isInitialized() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallBooleanMethod(this, _isInitialized8220); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.Animation.staticClass, _isInitialized8220); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartOffset8221; 
		public virtual void setStartOffset(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setStartOffset8221, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setStartOffset8221, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDuration8222; 
		public virtual void setDuration(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setDuration8222, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setDuration8222, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _restrictDuration8223; 
		public virtual void restrictDuration(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _restrictDuration8223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _restrictDuration8223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scaleCurrentDuration8224; 
		public virtual void scaleCurrentDuration(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _scaleCurrentDuration8224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _scaleCurrentDuration8224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStartTime8225; 
		public virtual void setStartTime(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setStartTime8225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setStartTime8225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startNow8226; 
		public virtual void startNow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _startNow8226); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _startNow8226); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRepeatMode8227; 
		public virtual void setRepeatMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setRepeatMode8227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setRepeatMode8227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRepeatCount8228; 
		public virtual void setRepeatCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setRepeatCount8228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setRepeatCount8228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFillEnabled8229; 
		public virtual bool isFillEnabled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallBooleanMethod(this, _isFillEnabled8229); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.Animation.staticClass, _isFillEnabled8229); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillEnabled8230; 
		public virtual void setFillEnabled(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setFillEnabled8230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setFillEnabled8230, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillBefore8231; 
		public virtual void setFillBefore(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setFillBefore8231, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setFillBefore8231, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFillAfter8232; 
		public virtual void setFillAfter(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setFillAfter8232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setFillAfter8232, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setZAdjustment8233; 
		public virtual void setZAdjustment(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setZAdjustment8233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setZAdjustment8233, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDetachWallpaper8234; 
		public virtual void setDetachWallpaper(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setDetachWallpaper8234, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setDetachWallpaper8234, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartTime8235; 
		public virtual long getStartTime() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallLongMethod(this, _getStartTime8235); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.animation.Animation.staticClass, _getStartTime8235); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDuration8236; 
		public virtual long getDuration() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallLongMethod(this, _getDuration8236); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.animation.Animation.staticClass, _getDuration8236); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStartOffset8237; 
		public virtual long getStartOffset() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallLongMethod(this, _getStartOffset8237); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.animation.Animation.staticClass, _getStartOffset8237); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRepeatMode8238; 
		public virtual int getRepeatMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallIntMethod(this, _getRepeatMode8238); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.animation.Animation.staticClass, _getRepeatMode8238); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFillBefore8239; 
		public virtual bool getFillBefore() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallBooleanMethod(this, _getFillBefore8239); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.Animation.staticClass, _getFillBefore8239); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFillAfter8240; 
		public virtual bool getFillAfter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallBooleanMethod(this, _getFillAfter8240); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.Animation.staticClass, _getFillAfter8240); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getZAdjustment8241; 
		public virtual int getZAdjustment() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallIntMethod(this, _getZAdjustment8241); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.view.animation.Animation.staticClass, _getZAdjustment8241); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDetachWallpaper8242; 
		public virtual bool getDetachWallpaper() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallBooleanMethod(this, _getDetachWallpaper8242); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.Animation.staticClass, _getDetachWallpaper8242); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willChangeTransformationMatrix8243; 
		public virtual bool willChangeTransformationMatrix() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallBooleanMethod(this, _willChangeTransformationMatrix8243); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.Animation.staticClass, _willChangeTransformationMatrix8243); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _willChangeBounds8244; 
		public virtual bool willChangeBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallBooleanMethod(this, _willChangeBounds8244); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.Animation.staticClass, _willChangeBounds8244); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAnimationListener8245; 
		public virtual void setAnimationListener(android.view.animation.Animation.AnimationListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _setAnimationListener8245, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _setAnimationListener8245, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ensureInterpolator8246; 
		protected virtual void ensureInterpolator() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _ensureInterpolator8246); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _ensureInterpolator8246); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _computeDurationHint8247; 
		public virtual long computeDurationHint() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallLongMethod(this, _computeDurationHint8247); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.view.animation.Animation.staticClass, _computeDurationHint8247); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransformation8248; 
		public virtual bool getTransformation(long arg0, android.view.animation.Transformation arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallBooleanMethod(this, _getTransformation8248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.Animation.staticClass, _getTransformation8248, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasStarted8249; 
		public virtual bool hasStarted() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallBooleanMethod(this, _hasStarted8249); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.Animation.staticClass, _hasStarted8249); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasEnded8250; 
		public virtual bool hasEnded() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				return @__env.CallBooleanMethod(this, _hasEnded8250); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.view.animation.Animation.staticClass, _hasEnded8250); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _applyTransformation8251; 
		protected virtual void applyTransformation(float arg0, android.view.animation.Transformation arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.view.animation.Animation)) 
				@__env.CallVoidMethod(this, _applyTransformation8251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.view.animation.Animation.staticClass, _applyTransformation8251, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Animation8252; 
		public Animation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.Animation.staticClass, _Animation8252, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Animation8253; 
		public Animation(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.view.animation.Animation.staticClass, _Animation8253, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		public static int INFINITE
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		public static int RESTART
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int REVERSE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int START_ON_FIRST_FRAME
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		public static int ABSOLUTE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int RELATIVE_TO_SELF
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int RELATIVE_TO_PARENT
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int ZORDER_NORMAL
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int ZORDER_TOP
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int ZORDER_BOTTOM
		{ 
			get 
			{ 
				return -1; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.view.animation.Animation.staticClass = @__class; 
			global::android.view.animation.Animation._clone8211 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "clone", "()Landroid/view/animation/Animation;"); 
			global::android.view.animation.Animation._start8212 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "start", "()V"); 
			global::android.view.animation.Animation._reset8213 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "reset", "()V"); 
			global::android.view.animation.Animation._initialize8214 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "initialize", "(IIII)V"); 
			global::android.view.animation.Animation._resolveSize8215 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "resolveSize", "(IFII)F"); 
			global::android.view.animation.Animation._getRepeatCount8216 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getRepeatCount", "()I"); 
			global::android.view.animation.Animation._setInterpolator8217 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/view/animation/Interpolator;)V"); 
			global::android.view.animation.Animation._setInterpolator8218 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setInterpolator", "(Landroid/content/Context;I)V"); 
			global::android.view.animation.Animation._getInterpolator8219 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getInterpolator", "()Landroid/view/animation/Interpolator;"); 
			global::android.view.animation.Animation._isInitialized8220 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "isInitialized", "()Z"); 
			global::android.view.animation.Animation._setStartOffset8221 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setStartOffset", "(J)V"); 
			global::android.view.animation.Animation._setDuration8222 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setDuration", "(J)V"); 
			global::android.view.animation.Animation._restrictDuration8223 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "restrictDuration", "(J)V"); 
			global::android.view.animation.Animation._scaleCurrentDuration8224 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "scaleCurrentDuration", "(F)V"); 
			global::android.view.animation.Animation._setStartTime8225 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setStartTime", "(J)V"); 
			global::android.view.animation.Animation._startNow8226 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "startNow", "()V"); 
			global::android.view.animation.Animation._setRepeatMode8227 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setRepeatMode", "(I)V"); 
			global::android.view.animation.Animation._setRepeatCount8228 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setRepeatCount", "(I)V"); 
			global::android.view.animation.Animation._isFillEnabled8229 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "isFillEnabled", "()Z"); 
			global::android.view.animation.Animation._setFillEnabled8230 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setFillEnabled", "(Z)V"); 
			global::android.view.animation.Animation._setFillBefore8231 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setFillBefore", "(Z)V"); 
			global::android.view.animation.Animation._setFillAfter8232 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setFillAfter", "(Z)V"); 
			global::android.view.animation.Animation._setZAdjustment8233 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setZAdjustment", "(I)V"); 
			global::android.view.animation.Animation._setDetachWallpaper8234 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setDetachWallpaper", "(Z)V"); 
			global::android.view.animation.Animation._getStartTime8235 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getStartTime", "()J"); 
			global::android.view.animation.Animation._getDuration8236 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getDuration", "()J"); 
			global::android.view.animation.Animation._getStartOffset8237 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getStartOffset", "()J"); 
			global::android.view.animation.Animation._getRepeatMode8238 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getRepeatMode", "()I"); 
			global::android.view.animation.Animation._getFillBefore8239 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getFillBefore", "()Z"); 
			global::android.view.animation.Animation._getFillAfter8240 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getFillAfter", "()Z"); 
			global::android.view.animation.Animation._getZAdjustment8241 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getZAdjustment", "()I"); 
			global::android.view.animation.Animation._getDetachWallpaper8242 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getDetachWallpaper", "()Z"); 
			global::android.view.animation.Animation._willChangeTransformationMatrix8243 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "willChangeTransformationMatrix", "()Z"); 
			global::android.view.animation.Animation._willChangeBounds8244 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "willChangeBounds", "()Z"); 
			global::android.view.animation.Animation._setAnimationListener8245 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "setAnimationListener", "(Landroid/view/animation/Animation$AnimationListener;)V"); 
			global::android.view.animation.Animation._ensureInterpolator8246 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "ensureInterpolator", "()V"); 
			global::android.view.animation.Animation._computeDurationHint8247 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "computeDurationHint", "()J"); 
			global::android.view.animation.Animation._getTransformation8248 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "getTransformation", "(JLandroid/view/animation/Transformation;)Z"); 
			global::android.view.animation.Animation._hasStarted8249 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "hasStarted", "()Z"); 
			global::android.view.animation.Animation._hasEnded8250 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "hasEnded", "()Z"); 
			global::android.view.animation.Animation._applyTransformation8251 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "applyTransformation", "(FLandroid/view/animation/Transformation;)V"); 
			global::android.view.animation.Animation._Animation8252 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "<init>", "()V"); 
			global::android.view.animation.Animation._Animation8253 = @__env.GetMethodID(global::android.view.animation.Animation.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V"); 
		} 
	} 
} 
