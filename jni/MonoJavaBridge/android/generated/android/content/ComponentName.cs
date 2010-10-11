namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class ComponentName : java.lang.Object, android.os.Parcelable, java.lang.Cloneable, java.lang.Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ComponentName()
		{
			InitJNI();
		}
		internal ComponentName(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals1106;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.ComponentName._equals1106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._equals1106, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString1107;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ComponentName._toString1107)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._toString1107)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode1108;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ComponentName._hashCode1108);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._hashCode1108);
		}
		internal static global::MonoJavaBridge.MethodId _clone1109;
		public new global::android.content.ComponentName clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ComponentName._clone1109)) as android.content.ComponentName;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._clone1109)) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _compareTo1110;
		public int compareTo(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ComponentName._compareTo1110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._compareTo1110, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compareTo1111;
		public int compareTo(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ComponentName._compareTo1111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._compareTo1111, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getClassName1112;
		public global::java.lang.String getClassName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ComponentName._getClassName1112)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._getClassName1112)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getPackageName1113;
		public global::java.lang.String getPackageName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ComponentName._getPackageName1113)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._getPackageName1113)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1114;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.ComponentName._writeToParcel1114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._writeToParcel1114, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1115;
		public static void writeToParcel(android.content.ComponentName arg0, android.os.Parcel arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(android.content.ComponentName.staticClass, global::android.content.ComponentName._writeToParcel1115, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1116;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.ComponentName._describeContents1116);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._describeContents1116);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel1117;
		public static global::android.content.ComponentName readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ComponentName.staticClass, global::android.content.ComponentName._readFromParcel1117, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _getShortClassName1118;
		public global::java.lang.String getShortClassName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ComponentName._getShortClassName1118)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._getShortClassName1118)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _flattenToString1119;
		public global::java.lang.String flattenToString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ComponentName._flattenToString1119)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._flattenToString1119)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _flattenToShortString1120;
		public global::java.lang.String flattenToShortString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ComponentName._flattenToShortString1120)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._flattenToShortString1120)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _unflattenFromString1121;
		public static global::android.content.ComponentName unflattenFromString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ComponentName.staticClass, global::android.content.ComponentName._unflattenFromString1121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.content.ComponentName;
		}
		internal static global::MonoJavaBridge.MethodId _toShortString1122;
		public global::java.lang.String toShortString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.ComponentName._toShortString1122)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.ComponentName.staticClass, global::android.content.ComponentName._toShortString1122)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ComponentName1123;
		public ComponentName(java.lang.String arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName1123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentName1124;
		public ComponentName(android.content.Context arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName1124, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentName1125;
		public ComponentName(android.content.Context arg0, java.lang.Class arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName1125, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ComponentName1126;
		public ComponentName(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ComponentName.staticClass, global::android.content.ComponentName._ComponentName1126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1127;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ComponentName.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ComponentName"));
			global::android.content.ComponentName._equals1106 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.ComponentName._toString1107 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.ComponentName._hashCode1108 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "hashCode", "()I");
			global::android.content.ComponentName._clone1109 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "clone", "()Landroid/content/ComponentName;");
			global::android.content.ComponentName._compareTo1110 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "compareTo", "(Ljava/lang/Object;)I");
			global::android.content.ComponentName._compareTo1111 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "compareTo", "(Landroid/content/ComponentName;)I");
			global::android.content.ComponentName._getClassName1112 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "getClassName", "()Ljava/lang/String;");
			global::android.content.ComponentName._getPackageName1113 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "getPackageName", "()Ljava/lang/String;");
			global::android.content.ComponentName._writeToParcel1114 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.ComponentName._writeToParcel1115 = @__env.GetStaticMethodIDNoThrow(global::android.content.ComponentName.staticClass, "writeToParcel", "(Landroid/content/ComponentName;Landroid/os/Parcel;)V");
			global::android.content.ComponentName._describeContents1116 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "describeContents", "()I");
			global::android.content.ComponentName._readFromParcel1117 = @__env.GetStaticMethodIDNoThrow(global::android.content.ComponentName.staticClass, "readFromParcel", "(Landroid/os/Parcel;)Landroid/content/ComponentName;");
			global::android.content.ComponentName._getShortClassName1118 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "getShortClassName", "()Ljava/lang/String;");
			global::android.content.ComponentName._flattenToString1119 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "flattenToString", "()Ljava/lang/String;");
			global::android.content.ComponentName._flattenToShortString1120 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "flattenToShortString", "()Ljava/lang/String;");
			global::android.content.ComponentName._unflattenFromString1121 = @__env.GetStaticMethodIDNoThrow(global::android.content.ComponentName.staticClass, "unflattenFromString", "(Ljava/lang/String;)Landroid/content/ComponentName;");
			global::android.content.ComponentName._toShortString1122 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "toShortString", "()Ljava/lang/String;");
			global::android.content.ComponentName._ComponentName1123 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.ComponentName._ComponentName1124 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/String;)V");
			global::android.content.ComponentName._ComponentName1125 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/content/Context;Ljava/lang/Class;)V");
			global::android.content.ComponentName._ComponentName1126 = @__env.GetMethodIDNoThrow(global::android.content.ComponentName.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
