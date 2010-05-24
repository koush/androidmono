namespace android.text.style 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TextAppearanceSpan : android.text.style.MetricAffectingSpan, ParcelableSpan
	{ 
		internal new static global::java.lang.Class staticClass; 
		static TextAppearanceSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.style.TextAppearanceSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.style.TextAppearanceSpan(@__env); 
			} 
		} 
		protected TextAppearanceSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7438; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TextAppearanceSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel7438, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.TextAppearanceSpan.staticClass, _writeToParcel7438, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7439; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TextAppearanceSpan)) 
				return @__env.CallIntMethod(this, _describeContents7439); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.TextAppearanceSpan.staticClass, _describeContents7439); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextSize7440; 
		public virtual int getTextSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TextAppearanceSpan)) 
				return @__env.CallIntMethod(this, _getTextSize7440); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.TextAppearanceSpan.staticClass, _getTextSize7440); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextColor7441; 
		public virtual android.content.res.ColorStateList getTextColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TextAppearanceSpan)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, _getTextColor7441)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.style.TextAppearanceSpan.staticClass, _getTextColor7441)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId7442; 
		public virtual int getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TextAppearanceSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId7442); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.TextAppearanceSpan.staticClass, _getSpanTypeId7442); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateDrawState7443; 
		public override void updateDrawState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TextAppearanceSpan)) 
				@__env.CallVoidMethod(this, _updateDrawState7443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.TextAppearanceSpan.staticClass, _updateDrawState7443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _updateMeasureState7444; 
		public override void updateMeasureState(android.text.TextPaint arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TextAppearanceSpan)) 
				@__env.CallVoidMethod(this, _updateMeasureState7444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.style.TextAppearanceSpan.staticClass, _updateMeasureState7444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFamily7445; 
		public virtual java.lang.String getFamily() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TextAppearanceSpan)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getFamily7445)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.style.TextAppearanceSpan.staticClass, _getFamily7445)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLinkTextColor7446; 
		public virtual android.content.res.ColorStateList getLinkTextColor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TextAppearanceSpan)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallObjectMethodPtr(this, _getLinkTextColor7446)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.res.ColorStateList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.style.TextAppearanceSpan.staticClass, _getLinkTextColor7446)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTextStyle7447; 
		public virtual int getTextStyle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.style.TextAppearanceSpan)) 
				return @__env.CallIntMethod(this, _getTextStyle7447); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.style.TextAppearanceSpan.staticClass, _getTextStyle7447); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextAppearanceSpan7448; 
		public TextAppearanceSpan(android.content.Context arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, _TextAppearanceSpan7448, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextAppearanceSpan7449; 
		public TextAppearanceSpan(java.lang.String arg0, int arg1, int arg2, android.content.res.ColorStateList arg3, android.content.res.ColorStateList arg4)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, _TextAppearanceSpan7449, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextAppearanceSpan7450; 
		public TextAppearanceSpan(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, _TextAppearanceSpan7450, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextAppearanceSpan7451; 
		public TextAppearanceSpan(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.style.TextAppearanceSpan.staticClass, _TextAppearanceSpan7451, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.style.TextAppearanceSpan.staticClass = @__class; 
			global::android.text.style.TextAppearanceSpan._writeToParcel7438 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.style.TextAppearanceSpan._describeContents7439 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "describeContents", "()I"); 
			global::android.text.style.TextAppearanceSpan._getTextSize7440 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getTextSize", "()I"); 
			global::android.text.style.TextAppearanceSpan._getTextColor7441 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getTextColor", "()Landroid/content/res/ColorStateList;"); 
			global::android.text.style.TextAppearanceSpan._getSpanTypeId7442 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getSpanTypeId", "()I"); 
			global::android.text.style.TextAppearanceSpan._updateDrawState7443 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "updateDrawState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.TextAppearanceSpan._updateMeasureState7444 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "updateMeasureState", "(Landroid/text/TextPaint;)V"); 
			global::android.text.style.TextAppearanceSpan._getFamily7445 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getFamily", "()Ljava/lang/String;"); 
			global::android.text.style.TextAppearanceSpan._getLinkTextColor7446 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getLinkTextColor", "()Landroid/content/res/ColorStateList;"); 
			global::android.text.style.TextAppearanceSpan._getTextStyle7447 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "getTextStyle", "()I"); 
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan7448 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/content/Context;II)V"); 
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan7449 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Ljava/lang/String;IILandroid/content/res/ColorStateList;Landroid/content/res/ColorStateList;)V"); 
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan7450 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
			global::android.text.style.TextAppearanceSpan._TextAppearanceSpan7451 = @__env.GetMethodID(global::android.text.style.TextAppearanceSpan.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
		} 
	} 
} 
