namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class StaticLayout : android.text.Layout
	{ 
		internal new static global::java.lang.Class staticClass; 
		static StaticLayout() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.StaticLayout), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.StaticLayout(@__env); 
			} 
		} 
		protected StaticLayout(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineCount6607; 
		public override int getLineCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallIntMethod(this, _getLineCount6607); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.StaticLayout.staticClass, _getLineCount6607); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsizedWidth6608; 
		public override int getEllipsizedWidth() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallIntMethod(this, _getEllipsizedWidth6608); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.StaticLayout.staticClass, _getEllipsizedWidth6608); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineTop6609; 
		public override int getLineTop(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallIntMethod(this, _getLineTop6609, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.StaticLayout.staticClass, _getLineTop6609, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineDescent6610; 
		public override int getLineDescent(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallIntMethod(this, _getLineDescent6610, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.StaticLayout.staticClass, _getLineDescent6610, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineStart6611; 
		public override int getLineStart(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallIntMethod(this, _getLineStart6611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.StaticLayout.staticClass, _getLineStart6611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParagraphDirection6612; 
		public override int getParagraphDirection(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallIntMethod(this, _getParagraphDirection6612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.StaticLayout.staticClass, _getParagraphDirection6612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineContainsTab6613; 
		public override bool getLineContainsTab(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallBooleanMethod(this, _getLineContainsTab6613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.text.StaticLayout.staticClass, _getLineContainsTab6613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineDirections6614; 
		public sealed override android.text.Layout.Directions getLineDirections(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallObjectMethodPtr(this, _getLineDirections6614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.Layout.Directions>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.StaticLayout.staticClass, _getLineDirections6614, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTopPadding6615; 
		public override int getTopPadding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallIntMethod(this, _getTopPadding6615); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.StaticLayout.staticClass, _getTopPadding6615); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBottomPadding6616; 
		public override int getBottomPadding() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallIntMethod(this, _getBottomPadding6616); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.StaticLayout.staticClass, _getBottomPadding6616); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLineForVertical6617; 
		public override int getLineForVertical(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallIntMethod(this, _getLineForVertical6617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.StaticLayout.staticClass, _getLineForVertical6617, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisStart6618; 
		public override int getEllipsisStart(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallIntMethod(this, _getEllipsisStart6618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.StaticLayout.staticClass, _getEllipsisStart6618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEllipsisCount6619; 
		public override int getEllipsisCount(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.StaticLayout)) 
				return @__env.CallIntMethod(this, _getEllipsisCount6619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.StaticLayout.staticClass, _getEllipsisCount6619, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StaticLayout6620; 
		public StaticLayout(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3, int arg4, android.text.Layout.Alignment arg5, float arg6, float arg7, bool arg8)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.StaticLayout.staticClass, _StaticLayout6620, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StaticLayout6621; 
		public StaticLayout(java.lang.CharSequence arg0, int arg1, int arg2, android.text.TextPaint arg3, int arg4, android.text.Layout.Alignment arg5, float arg6, float arg7, bool arg8, android.text.TextUtils.TruncateAt arg9, int arg10)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.StaticLayout.staticClass, _StaticLayout6621, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg7), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg8), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg9), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg10)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StaticLayout6622; 
		public StaticLayout(java.lang.CharSequence arg0, android.text.TextPaint arg1, int arg2, android.text.Layout.Alignment arg3, float arg4, float arg5, bool arg6)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.StaticLayout.staticClass, _StaticLayout6622, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg5), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg6)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.StaticLayout.staticClass = @__class; 
			global::android.text.StaticLayout._getLineCount6607 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineCount", "()I"); 
			global::android.text.StaticLayout._getEllipsizedWidth6608 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getEllipsizedWidth", "()I"); 
			global::android.text.StaticLayout._getLineTop6609 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineTop", "(I)I"); 
			global::android.text.StaticLayout._getLineDescent6610 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineDescent", "(I)I"); 
			global::android.text.StaticLayout._getLineStart6611 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineStart", "(I)I"); 
			global::android.text.StaticLayout._getParagraphDirection6612 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getParagraphDirection", "(I)I"); 
			global::android.text.StaticLayout._getLineContainsTab6613 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineContainsTab", "(I)Z"); 
			global::android.text.StaticLayout._getLineDirections6614 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineDirections", "(I)Landroid/text/Layout$Directions;"); 
			global::android.text.StaticLayout._getTopPadding6615 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getTopPadding", "()I"); 
			global::android.text.StaticLayout._getBottomPadding6616 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getBottomPadding", "()I"); 
			global::android.text.StaticLayout._getLineForVertical6617 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getLineForVertical", "(I)I"); 
			global::android.text.StaticLayout._getEllipsisStart6618 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getEllipsisStart", "(I)I"); 
			global::android.text.StaticLayout._getEllipsisCount6619 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "getEllipsisCount", "(I)I"); 
			global::android.text.StaticLayout._StaticLayout6620 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V"); 
			global::android.text.StaticLayout._StaticLayout6621 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;IILandroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZLandroid/text/TextUtils$TruncateAt;I)V"); 
			global::android.text.StaticLayout._StaticLayout6622 = @__env.GetMethodID(global::android.text.StaticLayout.staticClass, "<init>", "(Ljava/lang/CharSequence;Landroid/text/TextPaint;ILandroid/text/Layout$Alignment;FFZ)V"); 
		} 
	} 
} 
