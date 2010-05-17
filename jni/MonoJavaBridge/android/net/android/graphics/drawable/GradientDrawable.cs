namespace android.graphics.drawable 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GradientDrawable : android.graphics.drawable.Drawable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static GradientDrawable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.GradientDrawable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.drawable.GradientDrawable(@__env); 
			} 
		} 
		protected GradientDrawable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Orientation : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Orientation() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.drawable.GradientDrawable.Orientation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.drawable.GradientDrawable.Orientation(@__env); 
				} 
			} 
			internal Orientation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3402; 
			public static android.graphics.drawable.GradientDrawable.Orientation valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.GradientDrawable.Orientation>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.GradientDrawable.Orientation.staticClass, _valueOf3402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3403; 
			public static android.graphics.drawable.GradientDrawable.Orientation[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.drawable.GradientDrawable.Orientation.staticClass, _values3403)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BL_TR3404; 
			public static android.graphics.drawable.GradientDrawable.Orientation BL_TR
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BOTTOM_TOP3405; 
			public static android.graphics.drawable.GradientDrawable.Orientation BOTTOM_TOP
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _BR_TL3406; 
			public static android.graphics.drawable.GradientDrawable.Orientation BR_TL
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _LEFT_RIGHT3407; 
			public static android.graphics.drawable.GradientDrawable.Orientation LEFT_RIGHT
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RIGHT_LEFT3408; 
			public static android.graphics.drawable.GradientDrawable.Orientation RIGHT_LEFT
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TL_BR3409; 
			public static android.graphics.drawable.GradientDrawable.Orientation TL_BR
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TOP_BOTTOM3410; 
			public static android.graphics.drawable.GradientDrawable.Orientation TOP_BOTTOM
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TR_BL3411; 
			public static android.graphics.drawable.GradientDrawable.Orientation TR_BL
			{ 
				get 
				{ 
					return default(android.graphics.drawable.GradientDrawable.Orientation); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.drawable.GradientDrawable.Orientation.staticClass = @__class; 
				global::android.graphics.drawable.GradientDrawable.Orientation._valueOf3402 = @__env.GetStaticMethodID(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/drawable/GradientDrawable$Orientation;"); 
				global::android.graphics.drawable.GradientDrawable.Orientation._values3403 = @__env.GetStaticMethodID(global::android.graphics.drawable.GradientDrawable.Orientation.staticClass, "values", "()[Landroid/graphics/drawable/GradientDrawable/Orientation;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSize3412; 
		public virtual void setSize(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setSize3412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setSize3412, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _inflate3413; 
		public override void inflate(android.content.res.Resources arg0, org.xmlpull.v1.XmlPullParser arg1, android.util.AttributeSet arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _inflate3413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _inflate3413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw3414; 
		public override void draw(android.graphics.Canvas arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _draw3414, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _draw3414, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getChangingConfigurations3415; 
		public override int getChangingConfigurations() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallIntMethod(this, _getChangingConfigurations3415); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _getChangingConfigurations3415); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDither3416; 
		public override void setDither(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setDither3416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setDither3416, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setAlpha3417; 
		public override void setAlpha(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setAlpha3417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setAlpha3417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColorFilter3418; 
		public override void setColorFilter(android.graphics.ColorFilter arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setColorFilter3418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setColorFilter3418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOpacity3419; 
		public override int getOpacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallIntMethod(this, _getOpacity3419); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _getOpacity3419); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onLevelChange3420; 
		protected override bool onLevelChange(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallBooleanMethod(this, _onLevelChange3420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _onLevelChange3420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onBoundsChange3421; 
		protected override void onBoundsChange(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _onBoundsChange3421, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _onBoundsChange3421, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicWidth3422; 
		public override int getIntrinsicWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicWidth3422); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _getIntrinsicWidth3422); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getIntrinsicHeight3423; 
		public override int getIntrinsicHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallIntMethod(this, _getIntrinsicHeight3423); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _getIntrinsicHeight3423); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPadding3424; 
		public override bool getPadding(android.graphics.Rect arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return @__env.CallBooleanMethod(this, _getPadding3424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _getPadding3424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mutate3425; 
		public override android.graphics.drawable.Drawable mutate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallObjectMethodPtr(this, _mutate3425)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.GradientDrawable.staticClass, _mutate3425)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getConstantState3426; 
		public override android.graphics.drawable.Drawable.ConstantState getConstantState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallObjectMethodPtr(this, _getConstantState3426)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.drawable.Drawable.ConstantState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.graphics.drawable.GradientDrawable.staticClass, _getConstantState3426)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setColor3427; 
		public virtual void setColor(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setColor3427, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setColor3427, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCornerRadii3428; 
		public virtual void setCornerRadii(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setCornerRadii3428, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setCornerRadii3428, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCornerRadius3429; 
		public virtual void setCornerRadius(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setCornerRadius3429, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setCornerRadius3429, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStroke3430; 
		public virtual void setStroke(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setStroke3430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setStroke3430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStroke3431; 
		public virtual void setStroke(int arg0, int arg1, float arg2, float arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setStroke3431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setStroke3431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setShape3432; 
		public virtual void setShape(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setShape3432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setShape3432, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGradientType3433; 
		public virtual void setGradientType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setGradientType3433, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setGradientType3433, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGradientCenter3434; 
		public virtual void setGradientCenter(float arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setGradientCenter3434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setGradientCenter3434, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setGradientRadius3435; 
		public virtual void setGradientRadius(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setGradientRadius3435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setGradientRadius3435, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setUseLevel3436; 
		public virtual void setUseLevel(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.graphics.drawable.GradientDrawable)) 
				@__env.CallVoidMethod(this, _setUseLevel3436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.graphics.drawable.GradientDrawable.staticClass, _setUseLevel3436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GradientDrawable3437; 
		public GradientDrawable(android.graphics.drawable.GradientDrawable.Orientation arg0, int[] arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, _GradientDrawable3437, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GradientDrawable3438; 
		public GradientDrawable()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.drawable.GradientDrawable.staticClass, _GradientDrawable3438, this); 
		} 
		public static int RECTANGLE
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int OVAL
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int LINE
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		public static int RING
		{ 
			get 
			{ 
				return 3; 
			} 
		} 
		public static int LINEAR_GRADIENT
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int RADIAL_GRADIENT
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int SWEEP_GRADIENT
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.drawable.GradientDrawable.staticClass = @__class; 
			global::android.graphics.drawable.GradientDrawable._setSize3412 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setSize", "(II)V"); 
			global::android.graphics.drawable.GradientDrawable._inflate3413 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "inflate", "(Landroid/content/res/Resources;Lorg/xmlpull/v1/XmlPullParser;Landroid/util/AttributeSet;)V"); 
			global::android.graphics.drawable.GradientDrawable._draw3414 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "draw", "(Landroid/graphics/Canvas;)V"); 
			global::android.graphics.drawable.GradientDrawable._getChangingConfigurations3415 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getChangingConfigurations", "()I"); 
			global::android.graphics.drawable.GradientDrawable._setDither3416 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setDither", "(Z)V"); 
			global::android.graphics.drawable.GradientDrawable._setAlpha3417 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setAlpha", "(I)V"); 
			global::android.graphics.drawable.GradientDrawable._setColorFilter3418 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setColorFilter", "(Landroid/graphics/ColorFilter;)V"); 
			global::android.graphics.drawable.GradientDrawable._getOpacity3419 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getOpacity", "()I"); 
			global::android.graphics.drawable.GradientDrawable._onLevelChange3420 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "onLevelChange", "(I)Z"); 
			global::android.graphics.drawable.GradientDrawable._onBoundsChange3421 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "onBoundsChange", "(Landroid/graphics/Rect;)V"); 
			global::android.graphics.drawable.GradientDrawable._getIntrinsicWidth3422 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicWidth", "()I"); 
			global::android.graphics.drawable.GradientDrawable._getIntrinsicHeight3423 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getIntrinsicHeight", "()I"); 
			global::android.graphics.drawable.GradientDrawable._getPadding3424 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getPadding", "(Landroid/graphics/Rect;)Z"); 
			global::android.graphics.drawable.GradientDrawable._mutate3425 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "mutate", "()Landroid/graphics/drawable/Drawable;"); 
			global::android.graphics.drawable.GradientDrawable._getConstantState3426 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "getConstantState", "()Landroid/graphics/drawable/Drawable$ConstantState;"); 
			global::android.graphics.drawable.GradientDrawable._setColor3427 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setColor", "(I)V"); 
			global::android.graphics.drawable.GradientDrawable._setCornerRadii3428 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadii", "([F)V"); 
			global::android.graphics.drawable.GradientDrawable._setCornerRadius3429 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setCornerRadius", "(F)V"); 
			global::android.graphics.drawable.GradientDrawable._setStroke3430 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(II)V"); 
			global::android.graphics.drawable.GradientDrawable._setStroke3431 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setStroke", "(IIFF)V"); 
			global::android.graphics.drawable.GradientDrawable._setShape3432 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setShape", "(I)V"); 
			global::android.graphics.drawable.GradientDrawable._setGradientType3433 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientType", "(I)V"); 
			global::android.graphics.drawable.GradientDrawable._setGradientCenter3434 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientCenter", "(FF)V"); 
			global::android.graphics.drawable.GradientDrawable._setGradientRadius3435 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setGradientRadius", "(F)V"); 
			global::android.graphics.drawable.GradientDrawable._setUseLevel3436 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "setUseLevel", "(Z)V"); 
			global::android.graphics.drawable.GradientDrawable._GradientDrawable3437 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "(Landroid/graphics/drawable/GradientDrawable$Orientation;[I)V"); 
			global::android.graphics.drawable.GradientDrawable._GradientDrawable3438 = @__env.GetMethodID(global::android.graphics.drawable.GradientDrawable.staticClass, "<init>", "()V"); 
		} 
	} 
} 
