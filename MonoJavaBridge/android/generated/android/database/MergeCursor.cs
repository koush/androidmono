namespace android.database
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MergeCursor : android.database.AbstractCursor
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MergeCursor(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override short getShort(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::android.database.MergeCursor.staticClass, "getShort", "(I)S", ref global::android.database.MergeCursor._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override int getInt(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.MergeCursor.staticClass, "getInt", "(I)I", ref global::android.database.MergeCursor._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public override long getLong(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.MergeCursor.staticClass, "getLong", "(I)J", ref global::android.database.MergeCursor._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public override float getFloat(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.database.MergeCursor.staticClass, "getFloat", "(I)F", ref global::android.database.MergeCursor._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public override double getDouble(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.database.MergeCursor.staticClass, "getDouble", "(I)D", ref global::android.database.MergeCursor._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public override void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "close", "()V", ref global::android.database.MergeCursor._m5);
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public override global::java.lang.String getString(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.MergeCursor.staticClass, "getString", "(I)Ljava/lang/String;", ref global::android.database.MergeCursor._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public override void registerContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.MergeCursor._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public override void unregisterContentObserver(android.database.ContentObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V", ref global::android.database.MergeCursor._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Count
		{
			get
			{
				return getCount();
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public override int getCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.MergeCursor.staticClass, "getCount", "()I", ref global::android.database.MergeCursor._m9);
		}
		public new global::java.lang.String[] ColumnNames
		{
			get
			{
				return getColumnNames();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public override global::java.lang.String[] getColumnNames()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.database.MergeCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;", ref global::android.database.MergeCursor._m10) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public override byte[] getBlob(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.database.MergeCursor.staticClass, "getBlob", "(I)[B", ref global::android.database.MergeCursor._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public override bool isNull(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.MergeCursor.staticClass, "isNull", "(I)Z", ref global::android.database.MergeCursor._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public override void deactivate()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "deactivate", "()V", ref global::android.database.MergeCursor._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public override bool requery()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.MergeCursor.staticClass, "requery", "()Z", ref global::android.database.MergeCursor._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public override void registerDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.MergeCursor._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public override void unregisterDataSetObserver(android.database.DataSetObserver arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.MergeCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V", ref global::android.database.MergeCursor._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public override bool onMove(int arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.MergeCursor.staticClass, "onMove", "(II)Z", ref global::android.database.MergeCursor._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public MergeCursor(android.database.Cursor[] arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.MergeCursor._m18.native == global::System.IntPtr.Zero)
				global::android.database.MergeCursor._m18 = @__env.GetMethodIDNoThrow(global::android.database.MergeCursor.staticClass, "<init>", "([Landroid/database/Cursor;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.MergeCursor.staticClass, global::android.database.MergeCursor._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static MergeCursor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.MergeCursor.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/MergeCursor"));
		}
	}
}
