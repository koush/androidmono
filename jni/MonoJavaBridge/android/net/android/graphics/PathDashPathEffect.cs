namespace android.graphics 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PathDashPathEffect : android.graphics.PathEffect
	{ 
		internal new static global::java.lang.Class staticClass; 
		static PathDashPathEffect() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.PathDashPathEffect), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.graphics.PathDashPathEffect(@__env); 
			} 
		} 
		protected PathDashPathEffect(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Style : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Style() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.graphics.PathDashPathEffect.Style), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.graphics.PathDashPathEffect.Style(@__env); 
				} 
			} 
			internal Style(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf3003; 
			public static android.graphics.PathDashPathEffect.Style valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.graphics.PathDashPathEffect.Style>(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.PathDashPathEffect.Style.staticClass, _valueOf3003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values3004; 
			public static android.graphics.PathDashPathEffect.Style[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.graphics.PathDashPathEffect.Style.staticClass, _values3004)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _MORPH3005; 
			public static android.graphics.PathDashPathEffect.Style MORPH
			{ 
				get 
				{ 
					return default(android.graphics.PathDashPathEffect.Style); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _ROTATE3006; 
			public static android.graphics.PathDashPathEffect.Style ROTATE
			{ 
				get 
				{ 
					return default(android.graphics.PathDashPathEffect.Style); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _TRANSLATE3007; 
			public static android.graphics.PathDashPathEffect.Style TRANSLATE
			{ 
				get 
				{ 
					return default(android.graphics.PathDashPathEffect.Style); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.graphics.PathDashPathEffect.Style.staticClass = @__class; 
				global::android.graphics.PathDashPathEffect.Style._valueOf3003 = @__env.GetStaticMethodID(global::android.graphics.PathDashPathEffect.Style.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/graphics/PathDashPathEffect$Style;"); 
				global::android.graphics.PathDashPathEffect.Style._values3004 = @__env.GetStaticMethodID(global::android.graphics.PathDashPathEffect.Style.staticClass, "values", "()[Landroid/graphics/PathDashPathEffect/Style;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PathDashPathEffect3008; 
		public PathDashPathEffect(android.graphics.Path arg0, float arg1, float arg2, android.graphics.PathDashPathEffect.Style arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.graphics.PathDashPathEffect.staticClass, _PathDashPathEffect3008, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.graphics.PathDashPathEffect.staticClass = @__class; 
			global::android.graphics.PathDashPathEffect._PathDashPathEffect3008 = @__env.GetMethodID(global::android.graphics.PathDashPathEffect.staticClass, "<init>", "(Landroid/graphics/Path;FFLandroid/graphics/PathDashPathEffect$Style;)V"); 
		} 
	} 
} 
