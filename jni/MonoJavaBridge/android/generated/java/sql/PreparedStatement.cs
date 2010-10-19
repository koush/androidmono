namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.PreparedStatement_))]
	public interface PreparedStatement : Statement
	{
		void setBoolean(int arg0, bool arg1);
		void setByte(int arg0, byte arg1);
		void setShort(int arg0, short arg1);
		void setInt(int arg0, int arg1);
		void setLong(int arg0, long arg1);
		void setFloat(int arg0, float arg1);
		void setDouble(int arg0, double arg1);
		void setTimestamp(int arg0, java.sql.Timestamp arg1);
		void setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2);
		void setURL(int arg0, java.net.URL arg1);
		void setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2);
		void setTime(int arg0, java.sql.Time arg1);
		void setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2);
		void setDate(int arg0, java.sql.Date arg1);
		bool execute();
		void addBatch();
		void setString(int arg0, java.lang.String arg1);
		void setObject(int arg0, java.lang.Object arg1, int arg2);
		void setObject(int arg0, java.lang.Object arg1, int arg2, int arg3);
		void setObject(int arg0, java.lang.Object arg1);
		global::java.sql.ResultSetMetaData getMetaData();
		void setBytes(int arg0, byte[] arg1);
		void setBinaryStream(int arg0, java.io.InputStream arg1);
		void setBinaryStream(int arg0, java.io.InputStream arg1, int arg2);
		void setBinaryStream(int arg0, java.io.InputStream arg1, long arg2);
		void setNull(int arg0, int arg1, java.lang.String arg2);
		void setNull(int arg0, int arg1);
		void setBigDecimal(int arg0, java.math.BigDecimal arg1);
		void setAsciiStream(int arg0, java.io.InputStream arg1, int arg2);
		void setAsciiStream(int arg0, java.io.InputStream arg1);
		void setAsciiStream(int arg0, java.io.InputStream arg1, long arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1, int arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1);
		void setNString(int arg0, java.lang.String arg1);
		void setNCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void setNCharacterStream(int arg0, java.io.Reader arg1);
		void setNClob(int arg0, java.io.Reader arg1);
		void setNClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(int arg0, java.sql.Clob arg1);
		void setClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(int arg0, java.io.Reader arg1);
		void setBlob(int arg0, java.sql.Blob arg1);
		void setBlob(int arg0, java.io.InputStream arg1, long arg2);
		void setBlob(int arg0, java.io.InputStream arg1);
		global::java.sql.ResultSet executeQuery();
		int executeUpdate();
		void setUnicodeStream(int arg0, java.io.InputStream arg1, int arg2);
		void clearParameters();
		void setRef(int arg0, java.sql.Ref arg1);
		void setArray(int arg0, java.sql.Array arg1);
		global::java.sql.ParameterMetaData getParameterMetaData();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.PreparedStatement))]
	public sealed partial class PreparedStatement_ : java.lang.Object, PreparedStatement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static PreparedStatement_()
		{
			InitJNI();
		}
		internal PreparedStatement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean18861;
		 void java.sql.PreparedStatement.setBoolean(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBoolean18861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBoolean18861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte18862;
		 void java.sql.PreparedStatement.setByte(int arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setByte18862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setByte18862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort18863;
		 void java.sql.PreparedStatement.setShort(int arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setShort18863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setShort18863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt18864;
		 void java.sql.PreparedStatement.setInt(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setInt18864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setInt18864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong18865;
		 void java.sql.PreparedStatement.setLong(int arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setLong18865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setLong18865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat18866;
		 void java.sql.PreparedStatement.setFloat(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setFloat18866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setFloat18866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble18867;
		 void java.sql.PreparedStatement.setDouble(int arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setDouble18867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setDouble18867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp18868;
		 void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setTimestamp18868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setTimestamp18868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTimestamp18869;
		 void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setTimestamp18869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setTimestamp18869, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setURL18870;
		 void java.sql.PreparedStatement.setURL(int arg0, java.net.URL arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setURL18870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setURL18870, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setTime18871;
		 void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setTime18871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setTime18871, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setTime18872;
		 void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setTime18872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setTime18872, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDate18873;
		 void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setDate18873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setDate18873, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setDate18874;
		 void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setDate18874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setDate18874, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute18875;
		 bool java.sql.PreparedStatement.execute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._execute18875);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._execute18875);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch18876;
		 void java.sql.PreparedStatement.addBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._addBatch18876);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._addBatch18876);
		}
		internal static global::MonoJavaBridge.MethodId _setString18877;
		 void java.sql.PreparedStatement.setString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setString18877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setString18877, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setObject18878;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setObject18878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setObject18878, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setObject18879;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setObject18879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setObject18879, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _setObject18880;
		 void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setObject18880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setObject18880, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMetaData18881;
		 global::java.sql.ResultSetMetaData java.sql.PreparedStatement.getMetaData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getMetaData18881)) as java.sql.ResultSetMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSetMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getMetaData18881)) as java.sql.ResultSetMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _setBytes18882;
		 void java.sql.PreparedStatement.setBytes(int arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBytes18882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBytes18882, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream18883;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBinaryStream18883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBinaryStream18883, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream18884;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBinaryStream18884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBinaryStream18884, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBinaryStream18885;
		 void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBinaryStream18885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBinaryStream18885, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull18886;
		 void java.sql.PreparedStatement.setNull(int arg0, int arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNull18886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNull18886, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNull18887;
		 void java.sql.PreparedStatement.setNull(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNull18887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNull18887, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBigDecimal18888;
		 void java.sql.PreparedStatement.setBigDecimal(int arg0, java.math.BigDecimal arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBigDecimal18888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBigDecimal18888, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream18889;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setAsciiStream18889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setAsciiStream18889, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream18890;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setAsciiStream18890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setAsciiStream18890, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setAsciiStream18891;
		 void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setAsciiStream18891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setAsciiStream18891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream18892;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setCharacterStream18892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setCharacterStream18892, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream18893;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setCharacterStream18893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setCharacterStream18893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setCharacterStream18894;
		 void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setCharacterStream18894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setCharacterStream18894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNString18895;
		 void java.sql.PreparedStatement.setNString(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNString18895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNString18895, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream18896;
		 void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNCharacterStream18896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNCharacterStream18896, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setNCharacterStream18897;
		 void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNCharacterStream18897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNCharacterStream18897, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob18898;
		 void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNClob18898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNClob18898, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setNClob18899;
		 void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setNClob18899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setNClob18899, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob18900;
		 void java.sql.PreparedStatement.setClob(int arg0, java.sql.Clob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setClob18900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setClob18900, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setClob18901;
		 void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setClob18901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setClob18901, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setClob18902;
		 void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setClob18902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setClob18902, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob18903;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.sql.Blob arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBlob18903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBlob18903, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob18904;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1, long arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBlob18904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBlob18904, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setBlob18905;
		 void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setBlob18905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setBlob18905, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery18906;
		 global::java.sql.ResultSet java.sql.PreparedStatement.executeQuery() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeQuery18906)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeQuery18906)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate18907;
		 int java.sql.PreparedStatement.executeUpdate() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeUpdate18907);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeUpdate18907);
		}
		internal static global::MonoJavaBridge.MethodId _setUnicodeStream18908;
		 void java.sql.PreparedStatement.setUnicodeStream(int arg0, java.io.InputStream arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setUnicodeStream18908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setUnicodeStream18908, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _clearParameters18909;
		 void java.sql.PreparedStatement.clearParameters() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._clearParameters18909);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._clearParameters18909);
		}
		internal static global::MonoJavaBridge.MethodId _setRef18910;
		 void java.sql.PreparedStatement.setRef(int arg0, java.sql.Ref arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setRef18910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setRef18910, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setArray18911;
		 void java.sql.PreparedStatement.setArray(int arg0, java.sql.Array arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setArray18911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setArray18911, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getParameterMetaData18912;
		 global::java.sql.ParameterMetaData java.sql.PreparedStatement.getParameterMetaData() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ParameterMetaData>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getParameterMetaData18912)) as java.sql.ParameterMetaData;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ParameterMetaData>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getParameterMetaData18912)) as java.sql.ParameterMetaData;
		}
		internal static global::MonoJavaBridge.MethodId _close18913;
		 void java.sql.Statement.close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._close18913);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._close18913);
		}
		internal static global::MonoJavaBridge.MethodId _isClosed18914;
		 bool java.sql.Statement.isClosed() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._isClosed18914);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._isClosed18914);
		}
		internal static global::MonoJavaBridge.MethodId _execute18915;
		 bool java.sql.Statement.execute(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._execute18915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._execute18915, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute18916;
		 bool java.sql.Statement.execute(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._execute18916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._execute18916, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execute18917;
		 bool java.sql.Statement.execute(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._execute18917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._execute18917, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _execute18918;
		 bool java.sql.Statement.execute(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._execute18918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._execute18918, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _cancel18919;
		 void java.sql.Statement.cancel() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._cancel18919);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._cancel18919);
		}
		internal static global::MonoJavaBridge.MethodId _addBatch18920;
		 void java.sql.Statement.addBatch(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._addBatch18920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._addBatch18920, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getConnection18921;
		 global::java.sql.Connection java.sql.Statement.getConnection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getConnection18921)) as java.sql.Connection;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.Connection>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getConnection18921)) as java.sql.Connection;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSet18922;
		 global::java.sql.ResultSet java.sql.Statement.getResultSet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getResultSet18922)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getResultSet18922)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getWarnings18923;
		 global::java.sql.SQLWarning java.sql.Statement.getWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getWarnings18923)) as java.sql.SQLWarning;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getWarnings18923)) as java.sql.SQLWarning;
		}
		internal static global::MonoJavaBridge.MethodId _clearWarnings18924;
		 void java.sql.Statement.clearWarnings() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._clearWarnings18924);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._clearWarnings18924);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchDirection18925;
		 void java.sql.Statement.setFetchDirection(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setFetchDirection18925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setFetchDirection18925, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchDirection18926;
		 int java.sql.Statement.getFetchDirection() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getFetchDirection18926);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getFetchDirection18926);
		}
		internal static global::MonoJavaBridge.MethodId _setFetchSize18927;
		 void java.sql.Statement.setFetchSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setFetchSize18927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setFetchSize18927, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFetchSize18928;
		 int java.sql.Statement.getFetchSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getFetchSize18928);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getFetchSize18928);
		}
		internal static global::MonoJavaBridge.MethodId _executeQuery18929;
		 global::java.sql.ResultSet java.sql.Statement.executeQuery(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeQuery18929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeQuery18929, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate18930;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeUpdate18930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeUpdate18930, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate18931;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeUpdate18931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeUpdate18931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate18932;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeUpdate18932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeUpdate18932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _executeUpdate18933;
		 int java.sql.Statement.executeUpdate(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeUpdate18933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeUpdate18933, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxFieldSize18934;
		 int java.sql.Statement.getMaxFieldSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getMaxFieldSize18934);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getMaxFieldSize18934);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxFieldSize18935;
		 void java.sql.Statement.setMaxFieldSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setMaxFieldSize18935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setMaxFieldSize18935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getMaxRows18936;
		 int java.sql.Statement.getMaxRows() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getMaxRows18936);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getMaxRows18936);
		}
		internal static global::MonoJavaBridge.MethodId _setMaxRows18937;
		 void java.sql.Statement.setMaxRows(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setMaxRows18937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setMaxRows18937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEscapeProcessing18938;
		 void java.sql.Statement.setEscapeProcessing(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setEscapeProcessing18938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setEscapeProcessing18938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getQueryTimeout18939;
		 int java.sql.Statement.getQueryTimeout() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getQueryTimeout18939);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getQueryTimeout18939);
		}
		internal static global::MonoJavaBridge.MethodId _setQueryTimeout18940;
		 void java.sql.Statement.setQueryTimeout(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setQueryTimeout18940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setQueryTimeout18940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setCursorName18941;
		 void java.sql.Statement.setCursorName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setCursorName18941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setCursorName18941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getUpdateCount18942;
		 int java.sql.Statement.getUpdateCount() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getUpdateCount18942);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getUpdateCount18942);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults18943;
		 bool java.sql.Statement.getMoreResults() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getMoreResults18943);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getMoreResults18943);
		}
		internal static global::MonoJavaBridge.MethodId _getMoreResults18944;
		 bool java.sql.Statement.getMoreResults(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getMoreResults18944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getMoreResults18944, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetConcurrency18945;
		 int java.sql.Statement.getResultSetConcurrency() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getResultSetConcurrency18945);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getResultSetConcurrency18945);
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetType18946;
		 int java.sql.Statement.getResultSetType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getResultSetType18946);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getResultSetType18946);
		}
		internal static global::MonoJavaBridge.MethodId _clearBatch18947;
		 void java.sql.Statement.clearBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._clearBatch18947);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._clearBatch18947);
		}
		internal static global::MonoJavaBridge.MethodId _executeBatch18948;
		 int[] java.sql.Statement.executeBatch() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._executeBatch18948)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._executeBatch18948)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _getGeneratedKeys18949;
		 global::java.sql.ResultSet java.sql.Statement.getGeneratedKeys() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getGeneratedKeys18949)) as java.sql.ResultSet;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.sql.ResultSet>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getGeneratedKeys18949)) as java.sql.ResultSet;
		}
		internal static global::MonoJavaBridge.MethodId _getResultSetHoldability18950;
		 int java.sql.Statement.getResultSetHoldability() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_._getResultSetHoldability18950);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._getResultSetHoldability18950);
		}
		internal static global::MonoJavaBridge.MethodId _setPoolable18951;
		 void java.sql.Statement.setPoolable(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_._setPoolable18951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._setPoolable18951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isPoolable18952;
		 bool java.sql.Statement.isPoolable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_._isPoolable18952);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.sql.PreparedStatement_.staticClass, global::java.sql.PreparedStatement_._isPoolable18952);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.PreparedStatement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/PreparedStatement"));
			global::java.sql.PreparedStatement_._setBoolean18861 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBoolean", "(IZ)V");
			global::java.sql.PreparedStatement_._setByte18862 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setByte", "(IB)V");
			global::java.sql.PreparedStatement_._setShort18863 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setShort", "(IS)V");
			global::java.sql.PreparedStatement_._setInt18864 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setInt", "(II)V");
			global::java.sql.PreparedStatement_._setLong18865 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setLong", "(IJ)V");
			global::java.sql.PreparedStatement_._setFloat18866 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setFloat", "(IF)V");
			global::java.sql.PreparedStatement_._setDouble18867 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setDouble", "(ID)V");
			global::java.sql.PreparedStatement_._setTimestamp18868 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;)V");
			global::java.sql.PreparedStatement_._setTimestamp18869 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V");
			global::java.sql.PreparedStatement_._setURL18870 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setURL", "(ILjava/net/URL;)V");
			global::java.sql.PreparedStatement_._setTime18871 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V");
			global::java.sql.PreparedStatement_._setTime18872 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setTime", "(ILjava/sql/Time;)V");
			global::java.sql.PreparedStatement_._setDate18873 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V");
			global::java.sql.PreparedStatement_._setDate18874 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setDate", "(ILjava/sql/Date;)V");
			global::java.sql.PreparedStatement_._execute18875 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "execute", "()Z");
			global::java.sql.PreparedStatement_._addBatch18876 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "addBatch", "()V");
			global::java.sql.PreparedStatement_._setString18877 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setString", "(ILjava/lang/String;)V");
			global::java.sql.PreparedStatement_._setObject18878 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;I)V");
			global::java.sql.PreparedStatement_._setObject18879 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;II)V");
			global::java.sql.PreparedStatement_._setObject18880 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;)V");
			global::java.sql.PreparedStatement_._getMetaData18881 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;");
			global::java.sql.PreparedStatement_._setBytes18882 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBytes", "(I[B)V");
			global::java.sql.PreparedStatement_._setBinaryStream18883 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;)V");
			global::java.sql.PreparedStatement_._setBinaryStream18884 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.PreparedStatement_._setBinaryStream18885 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.PreparedStatement_._setNull18886 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNull", "(IILjava/lang/String;)V");
			global::java.sql.PreparedStatement_._setNull18887 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNull", "(II)V");
			global::java.sql.PreparedStatement_._setBigDecimal18888 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBigDecimal", "(ILjava/math/BigDecimal;)V");
			global::java.sql.PreparedStatement_._setAsciiStream18889 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.PreparedStatement_._setAsciiStream18890 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;)V");
			global::java.sql.PreparedStatement_._setAsciiStream18891 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;J)V");
			global::java.sql.PreparedStatement_._setCharacterStream18892 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;I)V");
			global::java.sql.PreparedStatement_._setCharacterStream18893 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.PreparedStatement_._setCharacterStream18894 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.PreparedStatement_._setNString18895 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNString", "(ILjava/lang/String;)V");
			global::java.sql.PreparedStatement_._setNCharacterStream18896 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;J)V");
			global::java.sql.PreparedStatement_._setNCharacterStream18897 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;)V");
			global::java.sql.PreparedStatement_._setNClob18898 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNClob", "(ILjava/io/Reader;)V");
			global::java.sql.PreparedStatement_._setNClob18899 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setNClob", "(ILjava/io/Reader;J)V");
			global::java.sql.PreparedStatement_._setClob18900 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/sql/Clob;)V");
			global::java.sql.PreparedStatement_._setClob18901 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/io/Reader;J)V");
			global::java.sql.PreparedStatement_._setClob18902 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/io/Reader;)V");
			global::java.sql.PreparedStatement_._setBlob18903 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/sql/Blob;)V");
			global::java.sql.PreparedStatement_._setBlob18904 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;J)V");
			global::java.sql.PreparedStatement_._setBlob18905 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;)V");
			global::java.sql.PreparedStatement_._executeQuery18906 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeQuery", "()Ljava/sql/ResultSet;");
			global::java.sql.PreparedStatement_._executeUpdate18907 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "()I");
			global::java.sql.PreparedStatement_._setUnicodeStream18908 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setUnicodeStream", "(ILjava/io/InputStream;I)V");
			global::java.sql.PreparedStatement_._clearParameters18909 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "clearParameters", "()V");
			global::java.sql.PreparedStatement_._setRef18910 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setRef", "(ILjava/sql/Ref;)V");
			global::java.sql.PreparedStatement_._setArray18911 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setArray", "(ILjava/sql/Array;)V");
			global::java.sql.PreparedStatement_._getParameterMetaData18912 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getParameterMetaData", "()Ljava/sql/ParameterMetaData;");
			global::java.sql.PreparedStatement_._close18913 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "close", "()V");
			global::java.sql.PreparedStatement_._isClosed18914 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "isClosed", "()Z");
			global::java.sql.PreparedStatement_._execute18915 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;[I)Z");
			global::java.sql.PreparedStatement_._execute18916 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;I)Z");
			global::java.sql.PreparedStatement_._execute18917 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;)Z");
			global::java.sql.PreparedStatement_._execute18918 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z");
			global::java.sql.PreparedStatement_._cancel18919 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "cancel", "()V");
			global::java.sql.PreparedStatement_._addBatch18920 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "addBatch", "(Ljava/lang/String;)V");
			global::java.sql.PreparedStatement_._getConnection18921 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getConnection", "()Ljava/sql/Connection;");
			global::java.sql.PreparedStatement_._getResultSet18922 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;");
			global::java.sql.PreparedStatement_._getWarnings18923 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;");
			global::java.sql.PreparedStatement_._clearWarnings18924 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "clearWarnings", "()V");
			global::java.sql.PreparedStatement_._setFetchDirection18925 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setFetchDirection", "(I)V");
			global::java.sql.PreparedStatement_._getFetchDirection18926 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getFetchDirection", "()I");
			global::java.sql.PreparedStatement_._setFetchSize18927 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setFetchSize", "(I)V");
			global::java.sql.PreparedStatement_._getFetchSize18928 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getFetchSize", "()I");
			global::java.sql.PreparedStatement_._executeQuery18929 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;");
			global::java.sql.PreparedStatement_._executeUpdate18930 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;I)I");
			global::java.sql.PreparedStatement_._executeUpdate18931 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[I)I");
			global::java.sql.PreparedStatement_._executeUpdate18932 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;)I");
			global::java.sql.PreparedStatement_._executeUpdate18933 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I");
			global::java.sql.PreparedStatement_._getMaxFieldSize18934 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getMaxFieldSize", "()I");
			global::java.sql.PreparedStatement_._setMaxFieldSize18935 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setMaxFieldSize", "(I)V");
			global::java.sql.PreparedStatement_._getMaxRows18936 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getMaxRows", "()I");
			global::java.sql.PreparedStatement_._setMaxRows18937 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setMaxRows", "(I)V");
			global::java.sql.PreparedStatement_._setEscapeProcessing18938 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setEscapeProcessing", "(Z)V");
			global::java.sql.PreparedStatement_._getQueryTimeout18939 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getQueryTimeout", "()I");
			global::java.sql.PreparedStatement_._setQueryTimeout18940 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setQueryTimeout", "(I)V");
			global::java.sql.PreparedStatement_._setCursorName18941 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setCursorName", "(Ljava/lang/String;)V");
			global::java.sql.PreparedStatement_._getUpdateCount18942 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getUpdateCount", "()I");
			global::java.sql.PreparedStatement_._getMoreResults18943 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getMoreResults", "()Z");
			global::java.sql.PreparedStatement_._getMoreResults18944 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getMoreResults", "(I)Z");
			global::java.sql.PreparedStatement_._getResultSetConcurrency18945 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getResultSetConcurrency", "()I");
			global::java.sql.PreparedStatement_._getResultSetType18946 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getResultSetType", "()I");
			global::java.sql.PreparedStatement_._clearBatch18947 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "clearBatch", "()V");
			global::java.sql.PreparedStatement_._executeBatch18948 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "executeBatch", "()[I");
			global::java.sql.PreparedStatement_._getGeneratedKeys18949 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getGeneratedKeys", "()Ljava/sql/ResultSet;");
			global::java.sql.PreparedStatement_._getResultSetHoldability18950 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "getResultSetHoldability", "()I");
			global::java.sql.PreparedStatement_._setPoolable18951 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "setPoolable", "(Z)V");
			global::java.sql.PreparedStatement_._isPoolable18952 = @__env.GetMethodIDNoThrow(global::java.sql.PreparedStatement_.staticClass, "isPoolable", "()Z");
		}
	}
}
