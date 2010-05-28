namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class PatternMatcher : java.lang.Object, Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static PatternMatcher() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.PatternMatcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.PatternMatcher(@__env); 
			} 
		} 
		protected PatternMatcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString5819; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.PatternMatcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.PatternMatcher._toString5819)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._toString5819)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType5820; 
		public virtual int getType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.PatternMatcher)) 
				return @__env.CallIntMethod(this, global::android.os.PatternMatcher._getType5820); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._getType5820); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPath5821; 
		public virtual global::java.lang.String getPath() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.PatternMatcher)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.PatternMatcher._getPath5821)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._getPath5821)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _match5822; 
		public virtual bool match(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.PatternMatcher)) 
				return @__env.CallBooleanMethod(this, global::android.os.PatternMatcher._match5822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._match5822, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5823; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.PatternMatcher)) 
				@__env.CallVoidMethod(this, global::android.os.PatternMatcher._writeToParcel5823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._writeToParcel5823, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents5824; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.PatternMatcher)) 
				return @__env.CallIntMethod(this, global::android.os.PatternMatcher._describeContents5824); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._describeContents5824); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PatternMatcher5825; 
		public PatternMatcher(java.lang.String arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._PatternMatcher5825, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _PatternMatcher5826; 
		public PatternMatcher(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.PatternMatcher.staticClass, global::android.os.PatternMatcher._PatternMatcher5826, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		public static int PATTERN_LITERAL
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int PATTERN_PREFIX
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		public static int PATTERN_SIMPLE_GLOB
		{ 
			get 
			{ 
				return 2; 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR5827; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.PatternMatcher.staticClass = @__class; 
			global::android.os.PatternMatcher._toString5819 = @__env.GetMethodID(global::android.os.PatternMatcher.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.os.PatternMatcher._getType5820 = @__env.GetMethodID(global::android.os.PatternMatcher.staticClass, "getType", "()I"); 
			global::android.os.PatternMatcher._getPath5821 = @__env.GetMethodID(global::android.os.PatternMatcher.staticClass, "getPath", "()Ljava/lang/String;"); 
			global::android.os.PatternMatcher._match5822 = @__env.GetMethodID(global::android.os.PatternMatcher.staticClass, "match", "(Ljava/lang/String;)Z"); 
			global::android.os.PatternMatcher._writeToParcel5823 = @__env.GetMethodID(global::android.os.PatternMatcher.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.os.PatternMatcher._describeContents5824 = @__env.GetMethodID(global::android.os.PatternMatcher.staticClass, "describeContents", "()I"); 
			global::android.os.PatternMatcher._PatternMatcher5825 = @__env.GetMethodID(global::android.os.PatternMatcher.staticClass, "<init>", "(Ljava/lang/String;I)V"); 
			global::android.os.PatternMatcher._PatternMatcher5826 = @__env.GetMethodID(global::android.os.PatternMatcher.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
