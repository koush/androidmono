namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class BoringLayout : android.text.Layout, android.text.TextUtils.EllipsizeCallback
	{ 
		internal new static global::java.lang.Class staticClass; 
		static BoringLayout() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.BoringLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.BoringLayout(@__env); 
			} 
		} 
		protected BoringLayout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Metrics : android.graphics.Paint.FontMetricsInt
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Metrics() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.BoringLayout.Metrics), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.text.BoringLayout.Metrics(@__env); 
				} 
			} 
			protected Metrics(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _toString6412; 
			public override java.lang.String toString() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.text.BoringLayout.Metrics)) 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6412)); 
				else 
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.BoringLayout.Metrics.staticClass, _toString6412)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Metrics6413; 
			public Metrics()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.text.BoringLayout.Metrics.staticClass, _Metrics6413, this); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _width6414; 
			public int width
			{ 
				get 
				{ 
					return default(int); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.text.BoringLayout.Metrics.staticClass = @__class; 
				global::android.text.BoringLayout.Metrics._toString6412 = @__env.GetMethodID(global::android.text.BoringLayout.Metrics.staticClass, "toString", "()Ljava/lang/String;"); 
				global::android.text.BoringLayout.Metrics._Metrics6413 = @__env.GetMethodID(global::android.text.BoringLayout.Metrics.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _make6415; 
		public static android.text.BoringLayout make(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallStaticObjectMethodPtr(android.text.BoringLayout.staticClass, _make6415, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _make6416; 
		public static android.text.BoringLayout make(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallStaticObjectMethodPtr(android.text.BoringLayout.staticClass, _make6416, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _draw6417; 
		public override void draw(android.graphics.Canvas arg0, android.graphics.Path arg1, android.graphics.Paint arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				@__env.CallVoidMethod(this, _draw6417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.BoringLayout.staticClass, _draw6417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getHeight6418; 
		public override int getHeight() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallIntMethod(this, _getHeight6418); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.BoringLayout.staticClass, _getHeight6418); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineCount6419; 
		public override int getLineCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallIntMethod(this, _getLineCount6419); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.BoringLayout.staticClass, _getLineCount6419); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsizedWidth6420; 
		public override int getEllipsizedWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallIntMethod(this, _getEllipsizedWidth6420); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.BoringLayout.staticClass, _getEllipsizedWidth6420); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineTop6421; 
		public override int getLineTop(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallIntMethod(this, _getLineTop6421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.BoringLayout.staticClass, _getLineTop6421, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineDescent6422; 
		public override int getLineDescent(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallIntMethod(this, _getLineDescent6422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.BoringLayout.staticClass, _getLineDescent6422, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineStart6423; 
		public override int getLineStart(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallIntMethod(this, _getLineStart6423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.BoringLayout.staticClass, _getLineStart6423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphDirection6424; 
		public override int getParagraphDirection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallIntMethod(this, _getParagraphDirection6424, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.BoringLayout.staticClass, _getParagraphDirection6424, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineContainsTab6425; 
		public override bool getLineContainsTab(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallBooleanMethod(this, _getLineContainsTab6425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.BoringLayout.staticClass, _getLineContainsTab6425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineDirections6426; 
		public sealed override android.text.Layout.Directions getLineDirections(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallObjectMethodPtr(this, _getLineDirections6426, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.BoringLayout.staticClass, _getLineDirections6426, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTopPadding6427; 
		public override int getTopPadding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallIntMethod(this, _getTopPadding6427); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.BoringLayout.staticClass, _getTopPadding6427); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPadding6428; 
		public override int getBottomPadding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallIntMethod(this, _getBottomPadding6428); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.BoringLayout.staticClass, _getBottomPadding6428); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineMax6429; 
		public override float getLineMax(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallFloatMethod(this, _getLineMax6429, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.text.BoringLayout.staticClass, _getLineMax6429, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisStart6430; 
		public override int getEllipsisStart(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallIntMethod(this, _getEllipsisStart6430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.BoringLayout.staticClass, _getEllipsisStart6430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisCount6431; 
		public override int getEllipsisCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return @__env.CallIntMethod(this, _getEllipsisCount6431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.BoringLayout.staticClass, _getEllipsisCount6431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceOrMake6432; 
		public virtual android.text.BoringLayout replaceOrMake(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallObjectMethodPtr(this, _replaceOrMake6432, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.BoringLayout.staticClass, _replaceOrMake6432, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _replaceOrMake6433; 
		public virtual android.text.BoringLayout replaceOrMake(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallObjectMethodPtr(this, _replaceOrMake6433, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.BoringLayout.staticClass, _replaceOrMake6433, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBoring6434; 
		public static android.text.BoringLayout.Metrics isBoring(java.lang.CharSequence arg0, android.text.TextPaint arg1, android.text.BoringLayout.Metrics arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout.Metrics>(@__env, @__env.CallStaticObjectMethodPtr(android.text.BoringLayout.staticClass, _isBoring6434, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBoring6435; 
		public static android.text.BoringLayout.Metrics isBoring(java.lang.CharSequence arg0, android.text.TextPaint arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.BoringLayout.Metrics>(@__env, @__env.CallStaticObjectMethodPtr(android.text.BoringLayout.staticClass, _isBoring6435, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ellipsized6436; 
		public virtual void ellipsized(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.BoringLayout)) 
				@__env.CallVoidMethod(this, _ellipsized6436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.BoringLayout.staticClass, _ellipsized6436, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BoringLayout6437; 
		public BoringLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7, android.text.TextUtils.TruncateAt arg8, int arg9)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.BoringLayout.staticClass, _BoringLayout6437, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg9)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _BoringLayout6438; 
		public BoringLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, android.text.BoringLayout.Metrics arg6, bool arg7)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.BoringLayout.staticClass, _BoringLayout6438, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.BoringLayout.staticClass = @__class; 
			global::android.text.BoringLayout._make6415 = @__env.GetStaticMethodID(global::android.text.BoringLayout.staticClass, "make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landroid/text/BoringLayout;"); 
			global::android.text.BoringLayout._make6416 = @__env.GetStaticMethodID(global::android.text.BoringLayout.staticClass, "make", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;"); 
			global::android.text.BoringLayout._draw6417 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "draw", "(Landroid/graphics/Canvas;Landroid/graphics/Path;Landroid/graphics/Paint;I)V"); 
			global::android.text.BoringLayout._getHeight6418 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getHeight", "()I"); 
			global::android.text.BoringLayout._getLineCount6419 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineCount", "()I"); 
			global::android.text.BoringLayout._getEllipsizedWidth6420 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getEllipsizedWidth", "()I"); 
			global::android.text.BoringLayout._getLineTop6421 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineTop", "(I)I"); 
			global::android.text.BoringLayout._getLineDescent6422 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineDescent", "(I)I"); 
			global::android.text.BoringLayout._getLineStart6423 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineStart", "(I)I"); 
			global::android.text.BoringLayout._getParagraphDirection6424 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getParagraphDirection", "(I)I"); 
			global::android.text.BoringLayout._getLineContainsTab6425 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineContainsTab", "(I)Z"); 
			global::android.text.BoringLayout._getLineDirections6426 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;"); 
			global::android.text.BoringLayout._getTopPadding6427 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getTopPadding", "()I"); 
			global::android.text.BoringLayout._getBottomPadding6428 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getBottomPadding", "()I"); 
			global::android.text.BoringLayout._getLineMax6429 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getLineMax", "(I)F"); 
			global::android.text.BoringLayout._getEllipsisStart6430 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getEllipsisStart", "(I)I"); 
			global::android.text.BoringLayout._getEllipsisCount6431 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "getEllipsisCount", "(I)I"); 
			global::android.text.BoringLayout._replaceOrMake6432 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)Landroid/text/BoringLayout;"); 
			global::android.text.BoringLayout._replaceOrMake6433 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "replaceOrMake", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)Landroid/text/BoringLayout;"); 
			global::android.text.BoringLayout._isBoring6434 = @__env.GetStaticMethodID(global::android.text.BoringLayout.staticClass, "isBoring", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;Landroid/text/BoringLayout$Metrics;)Landroid/text/BoringLayout$Metrics;"); 
			global::android.text.BoringLayout._isBoring6435 = @__env.GetStaticMethodID(global::android.text.BoringLayout.staticClass, "isBoring", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;)Landroid/text/BoringLayout$Metrics;"); 
			global::android.text.BoringLayout._ellipsized6436 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "ellipsized", "(II)V"); 
			global::android.text.BoringLayout._BoringLayout6437 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;ZLandroid/text/TextUtils$TruncateAt;I)V"); 
			global::android.text.BoringLayout._BoringLayout6438 = @__env.GetMethodID(global::android.text.BoringLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFLandroid/text/BoringLayout$Metrics;Z)V"); 
		} 
	} 
} 
