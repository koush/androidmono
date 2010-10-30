namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MatrixCursor : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MatrixCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class RowBuilder : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected RowBuilder(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual global::android.database.MatrixCursor.RowBuilder add(java.lang.Object arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.MatrixCursor.RowBuilder.staticClass, "add", "(Ljava/lang/Object;)Landroid/database/MatrixCursor$RowBuilder;", ref global::android.database.MatrixCursor.RowBuilder._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.database.MatrixCursor.RowBuilder;
			}
			static RowBuilder()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.MatrixCursor.RowBuilder.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MatrixCursor$RowBuilder"));
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override short getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.MatrixCursor.staticClass, "getShort", "(I)S", ref global::android.database.MatrixCursor._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.MatrixCursor.staticClass, "getInt", "(I)I", ref global::android.database.MatrixCursor._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.MatrixCursor.staticClass, "getLong", "(I)J", ref global::android.database.MatrixCursor._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override float getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.MatrixCursor.staticClass, "getFloat", "(I)F", ref global::android.database.MatrixCursor._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.MatrixCursor.staticClass, "getDouble", "(I)D", ref global::android.database.MatrixCursor._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.MatrixCursor.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.database.MatrixCursor._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.MatrixCursor.staticClass, "getCount", "()I", ref global::android.database.MatrixCursor._m6);
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override global::java.lang.String[] getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.MatrixCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.MatrixCursor._m7) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override bool isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.MatrixCursor.staticClass, "isNull", "(I)Z", ref global::android.database.MatrixCursor._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.database.MatrixCursor.RowBuilder newRow()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.MatrixCursor.staticClass, "newRow", "()Landroid/database/MatrixCursor$RowBuilder;", ref global::android.database.MatrixCursor._m9) as android.database.MatrixCursor.RowBuilder;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual void addRow(java.lang.Iterable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MatrixCursor.staticClass, "addRow", "(Ljava/lang/Iterable;)V", ref global::android.database.MatrixCursor._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual void addRow(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MatrixCursor.staticClass, "addRow", "([Ljava/lang/Object;)V", ref global::android.database.MatrixCursor._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public MatrixCursor(java.lang.String[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._m12.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._m12 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "<init>", "([Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public MatrixCursor(java.lang.String[] arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MatrixCursor._m13.native == global::System.IntPtr.Zero)
				global::android.database.MatrixCursor._m13 = @__env.GetMethodIDNoThrow(global::android.database.MatrixCursor.staticClass, "<init>", "([Ljava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MatrixCursor.staticClass, global::android.database.MatrixCursor._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static MatrixCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.MatrixCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MatrixCursor"));
		}
		internal static void InitJNI()
		{
		}
	}
}
