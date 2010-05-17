namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class Drawable : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Drawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.Drawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected Drawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface Callback 
		{ 
			void invalidateDrawable(android.graphics.drawable.Drawable arg0); 
			void scheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1, long arg2); 
			void unscheduleDrawable(android.graphics.drawable.Drawable arg0, java.lang.Runnable arg1); 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public abstract class ConstantState : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static ConstantState() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.Drawable.ConstantState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			protected ConstantState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3310; 
			public abstract int getChangingConfigurations(); 
			internal static global::net.sf.jni4net.jni.MethodId _newDrawable3311; 
			public abstract android.graphics.drawable.Drawable newDrawable(); 
			internal static global::net.sf.jni4net.jni.MethodId _newDrawable3312; 
			public virtual android.graphics.drawable.Drawable newDrawable(android.content.res.Resources arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.graphics.drawable.Drawable.ConstantState)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _newDrawable3312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.Drawable.ConstantState.staticClass, _newDrawable3312, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _ConstantState3313; 
			public ConstantState()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.graphics.drawable.Drawable.ConstantState.staticClass, _ConstantState3313, this); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.drawable.Drawable.ConstantState.staticClass = @__class; 
				global::android.graphics.drawable.Drawable.ConstantState._getChangingConfigurations3310 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "getChangingConfigurations", "()I"); 
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable3311 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "()Landroid/graphics/drawable/Drawable;"); 
				global::android.graphics.drawable.Drawable.ConstantState._newDrawable3312 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "newDrawable", "(Landroid/content/res/Resources;)Landroid/graphics/drawable/Drawable;"); 
				global::android.graphics.drawable.Drawable.ConstantState._ConstantState3313 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.ConstantState.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState3314; 
		public virtual int[] getState() 
		{ 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getState3314)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.Drawable.staticClass, _getState3314)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setState3315; 
		public virtual bool setState(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallBooleanMethod(this, _setState3315, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.Drawable.staticClass, _setState3315, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3316; 
		public virtual void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _inflate3316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _inflate3316, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3317; 
		public abstract void draw(android.graphics.Canvas arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setBounds3318; 
		public virtual void setBounds(int arg0, int arg1, int arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _setBounds3318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _setBounds3318, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBounds3319; 
		public virtual void setBounds(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _setBounds3319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _setBounds3319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyBounds3320; 
		public virtual void copyBounds(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _copyBounds3320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _copyBounds3320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyBounds3321; 
		public virtual android.graphics.Rect copyBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, _copyBounds3321)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.Drawable.staticClass, _copyBounds3321)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBounds3322; 
		public virtual android.graphics.Rect getBounds() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallObjectMethodPtr(this, _getBounds3322)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Rect>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.Drawable.staticClass, _getBounds3322)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setChangingConfigurations3323; 
		public virtual void setChangingConfigurations(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _setChangingConfigurations3323, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _setChangingConfigurations3323, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3324; 
		public virtual int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3324); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.Drawable.staticClass, _getChangingConfigurations3324); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither3325; 
		public virtual void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _setDither3325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _setDither3325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setFilterBitmap3326; 
		public virtual void setFilterBitmap(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _setFilterBitmap3326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _setFilterBitmap3326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCallback3327; 
		public virtual void setCallback(android.graphics.drawable.Drawable.Callback arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _setCallback3327, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _setCallback3327, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _invalidateSelf3328; 
		public virtual void invalidateSelf() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _invalidateSelf3328); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _invalidateSelf3328); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _scheduleSelf3329; 
		public virtual void scheduleSelf(java.lang.Runnable arg0, long arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _scheduleSelf3329, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _scheduleSelf3329, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unscheduleSelf3330; 
		public virtual void unscheduleSelf(java.lang.Runnable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _unscheduleSelf3330, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _unscheduleSelf3330, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3331; 
		public abstract void setAlpha(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3332; 
		public abstract void setColorFilter(android.graphics.ColorFilter arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3333; 
		public virtual void setColorFilter(int arg0, android.graphics.PorterDuff.Mode arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3333, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _setColorFilter3333, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _clearColorFilter3334; 
		public virtual void clearColorFilter() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _clearColorFilter3334); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _clearColorFilter3334); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isStateful3335; 
		public virtual bool isStateful() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallBooleanMethod(this, _isStateful3335); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.Drawable.staticClass, _isStateful3335); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCurrent3336; 
		public virtual android.graphics.drawable.Drawable getCurrent() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _getCurrent3336)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.Drawable.staticClass, _getCurrent3336)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLevel3337; 
		public virtual bool setLevel(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallBooleanMethod(this, _setLevel3337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.Drawable.staticClass, _setLevel3337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLevel3338; 
		public virtual int getLevel() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallIntMethod(this, _getLevel3338); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.Drawable.staticClass, _getLevel3338); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVisible3339; 
		public virtual bool setVisible(bool arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallBooleanMethod(this, _setVisible3339, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.Drawable.staticClass, _setVisible3339, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isVisible3340; 
		public virtual bool isVisible() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallBooleanMethod(this, _isVisible3340); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.Drawable.staticClass, _isVisible3340); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3341; 
		public abstract int getOpacity(); 
		internal static global::net.sf.jni4net.jni.MethodId _resolveOpacity3342; 
		public static int resolveOpacity(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticIntMethod(android.graphics.drawable.Drawable.staticClass, _resolveOpacity3342, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTransparentRegion3343; 
		public virtual android.graphics.Region getTransparentRegion() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallObjectMethodPtr(this, _getTransparentRegion3343)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.Region>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.Drawable.staticClass, _getTransparentRegion3343)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStateChange3344; 
		protected virtual bool onStateChange(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallBooleanMethod(this, _onStateChange3344, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.Drawable.staticClass, _onStateChange3344, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3345; 
		protected virtual bool onLevelChange(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallBooleanMethod(this, _onLevelChange3345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.Drawable.staticClass, _onLevelChange3345, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3346; 
		protected virtual void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				@__env.CallVoidMethod(this, _onBoundsChange3346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.Drawable.staticClass, _onBoundsChange3346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3347; 
		public virtual int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3347); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.Drawable.staticClass, _getIntrinsicWidth3347); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3348; 
		public virtual int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3348); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.Drawable.staticClass, _getIntrinsicHeight3348); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumWidth3349; 
		public virtual int getMinimumWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallIntMethod(this, _getMinimumWidth3349); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.Drawable.staticClass, _getMinimumWidth3349); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMinimumHeight3350; 
		public virtual int getMinimumHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallIntMethod(this, _getMinimumHeight3350); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.Drawable.staticClass, _getMinimumHeight3350); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3351; 
		public virtual bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return @__env.CallBooleanMethod(this, _getPadding3351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.Drawable.staticClass, _getPadding3351, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3352; 
		public virtual android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3352)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.Drawable.staticClass, _mutate3352)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromStream3353; 
		public static android.graphics.drawable.Drawable createFromStream(java.io.InputStream arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, _createFromStream3353, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromResourceStream3354; 
		public static android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, _createFromResourceStream3354, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromResourceStream3355; 
		public static android.graphics.drawable.Drawable createFromResourceStream(android.content.res.Resources arg0, android.util.TypedValue arg1, java.io.InputStream arg2, java.lang.String arg3, android.graphics.BitmapFactory.Options arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, _createFromResourceStream3355, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromXml3356; 
		public static android.graphics.drawable.Drawable createFromXml(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, _createFromXml3356, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromXmlInner3357; 
		public static android.graphics.drawable.Drawable createFromXmlInner(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, _createFromXmlInner3357, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromPath3358; 
		public static android.graphics.drawable.Drawable createFromPath(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.Drawable.staticClass, _createFromPath3358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3359; 
		public virtual android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.Drawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3359)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.Drawable.staticClass, _getConstantState3359)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Drawable3360; 
		public Drawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.Drawable.staticClass, _Drawable3360, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.Drawable.staticClass = @__class; 
			global::android.graphics.drawable.Drawable._getState3314 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getState", "()[I"); 
			global::android.graphics.drawable.Drawable._setState3315 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setState", "([I)Z"); 
			global::android.graphics.drawable.Drawable._inflate3316 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.Drawable._draw3317 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.Drawable._setBounds3318 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(IIII)V"); 
			global::android.graphics.drawable.Drawable._setBounds3319 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setBounds", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.Drawable._copyBounds3320 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.Drawable._copyBounds3321 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "copyBounds", "()Landroid/graphics/Rect;"); 
			global::android.graphics.drawable.Drawable._getBounds3322 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getBounds", "()Landroid/graphics/Rect;"); 
			global::android.graphics.drawable.Drawable._setChangingConfigurations3323 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setChangingConfigurations", "(I)V"); 
			global::android.graphics.drawable.Drawable._getChangingConfigurations3324 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.Drawable._setDither3325 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.drawable.Drawable._setFilterBitmap3326 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setFilterBitmap", "(Z)V"); 
			global::android.graphics.drawable.Drawable._setCallback3327 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setCallback", "(Landroid/graphics/drawable/Drawable$Callback;)V"); 
			global::android.graphics.drawable.Drawable._invalidateSelf3328 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "invalidateSelf", "()V"); 
			global::android.graphics.drawable.Drawable._scheduleSelf3329 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "scheduleSelf", "(Ljava/lang/Runnable;J)V"); 
			global::android.graphics.drawable.Drawable._unscheduleSelf3330 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "unscheduleSelf", "(Ljava/lang/Runnable;)V"); 
			global::android.graphics.drawable.Drawable._setAlpha3331 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.Drawable._setColorFilter3332 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.Drawable._setColorFilter3333 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setColorFilter", "(ILandroid/graphics/PorterDuff$Mode;)V"); 
			global::android.graphics.drawable.Drawable._clearColorFilter3334 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "clearColorFilter", "()V"); 
			global::android.graphics.drawable.Drawable._isStateful3335 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "isStateful", "()Z"); 
			global::android.graphics.drawable.Drawable._getCurrent3336 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getCurrent", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._setLevel3337 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setLevel", "(I)Z"); 
			global::android.graphics.drawable.Drawable._getLevel3338 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getLevel", "()I"); 
			global::android.graphics.drawable.Drawable._setVisible3339 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "setVisible", "(ZZ)Z"); 
			global::android.graphics.drawable.Drawable._isVisible3340 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "isVisible", "()Z"); 
			global::android.graphics.drawable.Drawable._getOpacity3341 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.Drawable._resolveOpacity3342 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "resolveOpacity", "(II)I"); 
			global::android.graphics.drawable.Drawable._getTransparentRegion3343 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getTransparentRegion", "()Landroid/graphics/Region;"); 
			global::android.graphics.drawable.Drawable._onStateChange3344 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "onStateChange", "([I)Z"); 
			global::android.graphics.drawable.Drawable._onLevelChange3345 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "onLevelChange", "(I)Z"); 
			global::android.graphics.drawable.Drawable._onBoundsChange3346 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.Drawable._getIntrinsicWidth3347 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.Drawable._getIntrinsicHeight3348 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.Drawable._getMinimumWidth3349 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getMinimumWidth", "()I"); 
			global::android.graphics.drawable.Drawable._getMinimumHeight3350 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getMinimumHeight", "()I"); 
			global::android.graphics.drawable.Drawable._getPadding3351 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.Drawable._mutate3352 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromStream3353 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromStream", "(Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromResourceStream3354 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromResourceStream3355 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromResourceStream", "(Landroid/content/res/Resources;Landroid/util/TypedValue;Ljava/io/InputStream;Ljava/lang/String;Landroid/graphics/BitmapFactory$Options;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromXml3356 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromXml", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromXmlInner3357 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromXmlInner", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._createFromPath3358 = @__env.GetStaticMethodID(global::android.graphics.drawable.Drawable.staticClass, "createFromPath", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.Drawable._getConstantState3359 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.Drawable._Drawable3360 = @__env.GetMethodID(global::android.graphics.drawable.Drawable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
