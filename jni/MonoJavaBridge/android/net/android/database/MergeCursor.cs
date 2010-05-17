namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class MergeCursor : android.database.AbstractCursor
	{ 
		internal new static global::java.lang.Class staticClass; 
		static MergeCursor() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.MergeCursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.MergeCursor(@__env); 
			} 
		} 
		protected MergeCursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShort2223; 
		public override short getShort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return @__env.CallShortMethod(this, _getShort2223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, android.database.MergeCursor.staticClass, _getShort2223, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2224; 
		public override int getInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return @__env.CallIntMethod(this, _getInt2224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.MergeCursor.staticClass, _getInt2224, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong2225; 
		public override long getLong(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return @__env.CallLongMethod(this, _getLong2225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.MergeCursor.staticClass, _getLong2225, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2226; 
		public override float getFloat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return @__env.CallFloatMethod(this, _getFloat2226, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.database.MergeCursor.staticClass, _getFloat2226, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2227; 
		public override double getDouble(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return @__env.CallDoubleMethod(this, _getDouble2227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.database.MergeCursor.staticClass, _getDouble2227, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2228; 
		public override void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				@__env.CallVoidMethod(this, _close2228); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.MergeCursor.staticClass, _close2228); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2229; 
		public override java.lang.String getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString2229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.MergeCursor.staticClass, _getString2229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2230; 
		public override void registerContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				@__env.CallVoidMethod(this, _registerContentObserver2230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.MergeCursor.staticClass, _registerContentObserver2230, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2231; 
		public override void unregisterContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				@__env.CallVoidMethod(this, _unregisterContentObserver2231, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.MergeCursor.staticClass, _unregisterContentObserver2231, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount2232; 
		public override int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return @__env.CallIntMethod(this, _getCount2232); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.MergeCursor.staticClass, _getCount2232); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2233; 
		public override java.lang.String[] getColumnNames() 
		{ 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getColumnNames2233)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.MergeCursor.staticClass, _getColumnNames2233)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2234; 
		public override byte[] getBlob(int arg0) 
		{ 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getBlob2234, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.MergeCursor.staticClass, _getBlob2234, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2235; 
		public override bool isNull(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return @__env.CallBooleanMethod(this, _isNull2235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.MergeCursor.staticClass, _isNull2235, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2236; 
		public override void deactivate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				@__env.CallVoidMethod(this, _deactivate2236); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.MergeCursor.staticClass, _deactivate2236); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requery2237; 
		public override bool requery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return @__env.CallBooleanMethod(this, _requery2237); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.MergeCursor.staticClass, _requery2237); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2238; 
		public override void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				@__env.CallVoidMethod(this, _registerDataSetObserver2238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.MergeCursor.staticClass, _registerDataSetObserver2238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2239; 
		public override void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				@__env.CallVoidMethod(this, _unregisterDataSetObserver2239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.MergeCursor.staticClass, _unregisterDataSetObserver2239, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMove2240; 
		public override bool onMove(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.MergeCursor)) 
				return @__env.CallBooleanMethod(this, _onMove2240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.MergeCursor.staticClass, _onMove2240, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _MergeCursor2241; 
		public MergeCursor(android.database.Cursor[] arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.MergeCursor.staticClass, _MergeCursor2241, this, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.database.Cursor[], android.database.Cursor>(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.MergeCursor.staticClass = @__class; 
			global::android.database.MergeCursor._getShort2223 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getShort", "(I)S"); 
			global::android.database.MergeCursor._getInt2224 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getInt", "(I)I"); 
			global::android.database.MergeCursor._getLong2225 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getLong", "(I)J"); 
			global::android.database.MergeCursor._getFloat2226 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getFloat", "(I)F"); 
			global::android.database.MergeCursor._getDouble2227 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getDouble", "(I)D"); 
			global::android.database.MergeCursor._close2228 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "close", "()V"); 
			global::android.database.MergeCursor._getString2229 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.database.MergeCursor._registerContentObserver2230 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.MergeCursor._unregisterContentObserver2231 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.MergeCursor._getCount2232 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getCount", "()I"); 
			global::android.database.MergeCursor._getColumnNames2233 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;"); 
			global::android.database.MergeCursor._getBlob2234 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "getBlob", "(I)[B"); 
			global::android.database.MergeCursor._isNull2235 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "isNull", "(I)Z"); 
			global::android.database.MergeCursor._deactivate2236 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "deactivate", "()V"); 
			global::android.database.MergeCursor._requery2237 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "requery", "()Z"); 
			global::android.database.MergeCursor._registerDataSetObserver2238 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.MergeCursor._unregisterDataSetObserver2239 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.MergeCursor._onMove2240 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "onMove", "(II)Z"); 
			global::android.database.MergeCursor._MergeCursor2241 = @__env.GetMethodID(global::android.database.MergeCursor.staticClass, "<init>", "([Landroid/database/Cursor;)V"); 
		} 
	} 
} 
